using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EdFi.Common;
using EdFi.Roster.ChangeQueries.Models;
using EdFi.Roster.Models;
using EdFi.Roster.Sdk.Client;
using EdFi.Roster.Sdk.Models.Resources;
using Newtonsoft.Json;

namespace EdFi.Roster.ChangeQueries.Services
{
    public abstract class ApiService<TApiAccessor, TResource, TRecord>
        where TApiAccessor : IApiAccessor
        where TResource : class
        where TRecord : RosterDataRecord, new()
    {
        private readonly IDataService _dataService;
        private readonly IResponseHandleService _responseHandleService;
        private readonly IApiFacade _apiFacade;
        private readonly ChangeQueryService _changeQueryService;

        private delegate Task<ApiResponse<List<T>>> GetPageAsync<T>(TApiAccessor api, int offset, int limit, int minChangeVersion, int maxChangeVersion);

        protected ApiService(
            IDataService dataService,
            IResponseHandleService responseHandleService,
            IApiFacade apiFacade,
            ChangeQueryService changeQueryService)
        {
            _dataService = dataService;
            _responseHandleService = responseHandleService;
            _apiFacade = apiFacade;
            _changeQueryService = changeQueryService;
        }

        protected abstract string ApiRoute { get; }

        protected abstract string ResourceType { get; }

        protected abstract Task<ApiResponse<List<TResource>>> GetChangesAsync(TApiAccessor api, int offset, int limit, int minChangeVersion, int maxChangeVersion);

        protected abstract Task<ApiResponse<List<DeletedResource>>> GetDeletionsAsync(TApiAccessor api, int offset, int limit, int minChangeVersion, int maxChangeVersion);

        protected abstract string GetResourceId(TResource resource);

        public async Task<DataSyncResponseModel> RetrieveAndSyncResources(long minChangeVersion, long maxChangeVersion)
        {
            var response = await GetAllResources(ApiRoute, minChangeVersion, maxChangeVersion, GetChangesAsync);

            // Sync retrieved records to local db
            var records = response.FullDataSet.Select(x =>
                new TRecord
                {
                    Content = JsonConvert.SerializeObject(x),
                    ResourceId = GetResourceId(x)
                }).ToList();
            var countAdded = await _dataService.AddOrUpdateAllAsync(records);

            var deletesResponse = await GetAllResources($"{ApiRoute}/deletes", minChangeVersion, maxChangeVersion, GetDeletionsAsync);

            // Sync deleted records to local db
            var countDeleted = 0;
            if (deletesResponse.FullDataSet.Any())
            {
                var resourceIds = deletesResponse.FullDataSet.Select(x => x.Id).ToList();
                await _dataService.DeleteAllAsync<TRecord>(resourceIds);
                countDeleted = resourceIds.Count;
            }

            // Save latest change version 
            await _changeQueryService.Save(maxChangeVersion, ResourceType);

            return new DataSyncResponseModel
            {
                ResourceName = ResourceType,
                AddedRecordsCount = countAdded,
                UpdatedRecordsCount = response.GeneralInfo.TotalRecords - countAdded,
                DeletedRecordsCount = countDeleted,

                ChangeDetails = response.GeneralInfo,
                DeletionDetails = deletesResponse.GeneralInfo
            };
        }

        private async Task<ExtendedInfoResponse<List<T>>> GetAllResources<T>(
            string apiRoute, long minChangeVersion, long maxChangeVersion,
            GetPageAsync<T> getPageAsync)
            where T : class
        {
            var queryParams = new Dictionary<string, string>
            {
                {"minChangeVersion", minChangeVersion.ToString()},
                {"maxChangeVersion", maxChangeVersion.ToString()}
            };

            var api = await _apiFacade.GetApiClassInstance<TApiAccessor>();
            var limit = 100;
            var offset = 0;
            var response = new ExtendedInfoResponse<List<T>>();
            int currResponseRecordCount = 0;

            do
            {
                var errorMessage = string.Empty;

                queryParams["offset"] = offset.ToString();
                queryParams["limit"] = limit.ToString();

                var responseUri = _apiFacade.BuildResponseUri(apiRoute, queryParams);

                ApiResponse<List<T>> currentApiResponse = null;
                try
                {
                    currentApiResponse = await getPageAsync(api, offset, limit, (int)minChangeVersion, (int)maxChangeVersion);
                }
                catch (ApiException exception)
                {
                    errorMessage = exception.Message;
                    if (exception.ErrorCode.Equals((int) HttpStatusCode.Unauthorized))
                    {
                        api = await _apiFacade.GetApiClassInstance<TApiAccessor>(true);
                        currentApiResponse = await getPageAsync(api, offset, limit, (int)minChangeVersion, (int)maxChangeVersion);
                        errorMessage = string.Empty;
                    }
                }

                if (currentApiResponse == null) continue;
                currResponseRecordCount = currentApiResponse.Data.Count;
                offset += limit;
                response = await _responseHandleService.Handle(currentApiResponse, response, responseUri, errorMessage);
            } while (currResponseRecordCount >= limit);

            response.GeneralInfo.TotalRecords = response.FullDataSet.Count;
            response.GeneralInfo.ResponseData = JsonConvert.SerializeObject(response.FullDataSet, Formatting.Indented);
            return response;
        }
    }
}
