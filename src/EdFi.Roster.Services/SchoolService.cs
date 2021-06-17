using EdFi.Roster.Models;
using EdFi.Roster.Sdk.Models.EnrollmentComposites;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EdFi.Common;
using EdFi.Roster.Sdk.Api.EnrollmentComposites;
using EdFi.Roster.Sdk.Client;
using Newtonsoft.Json;

namespace EdFi.Roster.Services
{
    public class SchoolService
    {
        private readonly IDataService _rosterDataService;
        private readonly IResponseHandleService _responseHandleService;
        private readonly IApiFacade _apiFacade;

        public SchoolService(IDataService rosterDataService
            , IResponseHandleService responseHandleService
            , IApiFacade apiFacade)
        {
            _rosterDataService = rosterDataService;
            _responseHandleService = responseHandleService;
            _apiFacade = apiFacade;
        }

        public async Task Save(List<School> schools)
        {
            var schoolList = schools.Select(school =>
                new RosterSchoolComposite {Content = JsonConvert.SerializeObject(school), ResourceId = school.Id}).ToList();

            await _rosterDataService.SaveAsync(schoolList);
        }

        public async Task<List<School>> ReadAllAsync()
        {
            var schools = await _rosterDataService.ReadAllAsync<RosterSchoolComposite>();
            return schools.Select(school => JsonConvert.DeserializeObject<School>(school.Content)).ToList();
        }

        private delegate Task<ApiResponse<List<TResource>>> GetPageAsync<in TApiAccessor, TResource>(TApiAccessor api, int offset, int limit)
            where TApiAccessor : IApiAccessor;

        public async Task<ExtendedInfoResponse<List<School>>> GetAllSchoolsWithExtendedInfoAsync()
        {
            return await GetAllResourcesWithExtendedInfoAsync<SchoolsApi, School>(
                ApiRoutes.SchoolsComposite,
                async (api, offset, limit) =>
                    await api.GetSchoolsWithHttpInfoAsync(offset, limit));
        }

        private async Task<ExtendedInfoResponse<List<TResource>>> GetAllResourcesWithExtendedInfoAsync<TApiAccessor, TResource>(
            string apiRoute, GetPageAsync<TApiAccessor, TResource> getPageAsync)
            where TApiAccessor : IApiAccessor
            where TResource : class
        {
            var api = await _apiFacade.GetApiClassInstance<TApiAccessor>();
            var limit = 100;
            var offset = 0;
            var response = new ExtendedInfoResponse<List<TResource>>();
            int currResponseRecordCount = 0;
            var queryParams = new Dictionary<string, string> { { "offset", offset.ToString() }, { "limit", limit.ToString() } };
            do
            {
                var errorMessage = string.Empty;
                queryParams["offset"] = offset.ToString();
                queryParams["limit"] = limit.ToString();
                var responseUri = _apiFacade.BuildResponseUri(apiRoute, queryParams);
                ApiResponse<List<TResource>> currentApiResponse = null;
                try
                {
                    currentApiResponse = await getPageAsync(api, offset, limit);
                }
                catch (ApiException exception)
                {
                    errorMessage = exception.Message;
                    if (exception.ErrorCode.Equals((int)HttpStatusCode.Unauthorized))
                    {
                        api = await _apiFacade.GetApiClassInstance<TApiAccessor>(true);
                        currentApiResponse = await getPageAsync(api, offset, limit);
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
