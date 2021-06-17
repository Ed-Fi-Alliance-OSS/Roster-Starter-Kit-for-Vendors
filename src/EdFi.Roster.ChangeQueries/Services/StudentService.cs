using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdFi.Common;
using EdFi.Roster.ChangeQueries.Models;
using EdFi.Roster.ChangeQueries.Services.ApiSdk;
using EdFi.Roster.Models;
using EdFi.Roster.Sdk.Api.Resources;
using EdFi.Roster.Sdk.Client;
using EdFi.Roster.Sdk.Models.Resources;
using Newtonsoft.Json;

namespace EdFi.Roster.ChangeQueries.Services
{
    public class StudentService : ApiService<StudentsApi, EdFiStudent, RosterStudentResource>
    {
        private readonly IDataService _dataService;
        private readonly ChangeQueryService _changeQueryService;

        public StudentService(
            IDataService dataService,
            IResponseHandleService responseHandleService,
            IApiFacade apiFacade,
            ChangeQueryService changeQueryService)
            : base(responseHandleService, apiFacade)
        {
            _dataService = dataService;
            _changeQueryService = changeQueryService;
        }

        protected override string ApiRoute => ApiRoutes.StudentsResource;

        protected override string ResourceType => ResourceTypes.Students;

        protected override async Task<ApiResponse<List<EdFiStudent>>> GetChangesAsync(StudentsApi api, int offset, int limit, int minChangeVersion, int maxChangeVersion)
            => await api.GetStudentsWithHttpInfoAsync(offset, limit, minChangeVersion, maxChangeVersion);

        protected override async Task<ApiResponse<List<DeletedResource>>> GetDeletionsAsync(StudentsApi api, int offset, int limit, int minChangeVersion, int maxChangeVersion)
            => await api.DeletesStudentsWithHttpInfoAsync(offset, limit, minChangeVersion, maxChangeVersion);

        public async Task<DataSyncResponseModel> RetrieveAndSyncResources(long minVersion, long maxVersion)
        {
            var queryParams = new Dictionary<string, string> { { "minChangeVersion", minVersion.ToString() },
                { "maxChangeVersion", maxVersion.ToString() } };

            var response = await GetAllResources(ApiRoute, queryParams, (int)minVersion, (int)maxVersion, GetChangesAsync);

            // Sync retrieved records to local db
            var records = response.FullDataSet.Select(x =>
                new RosterStudentResource
                {
                    Content = JsonConvert.SerializeObject(x),
                    ResourceId = GetResourceId(x)
                }).ToList();
            var countAdded = await _dataService.AddOrUpdateAllAsync(records);

            var deletesResponse = await GetAllResources($"{ApiRoute}/deletes", queryParams, (int)minVersion, (int)maxVersion, GetDeletionsAsync);

            // Sync deleted records to local db
            var countDeleted = 0;
            if (deletesResponse.FullDataSet.Any())
            {
                var resourceIds = deletesResponse.FullDataSet.Select(x => x.Id).ToList();
                await _dataService.DeleteAllAsync<RosterStudentResource>(resourceIds);
                countDeleted = resourceIds.Count;
            }

            // Save latest change version 
            await _changeQueryService.Save(maxVersion, ResourceType);

            return new DataSyncResponseModel
            {
                ResourceName = ResourceType,
                AddedRecordsCount = countAdded,
                UpdatedRecordsCount = response.FullDataSet.Count - countAdded,
                DeletedRecordsCount = countDeleted
            };
        }

        protected override string GetResourceId(EdFiStudent resource) => resource.Id;
    }
}
