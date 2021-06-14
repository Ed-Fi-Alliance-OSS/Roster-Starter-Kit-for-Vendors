using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdFi.Common;
using EdFi.Roster.ChangeQueries.Models;
using EdFi.Roster.ChangeQueries.Services.ApiSdk;
using EdFi.Roster.Models;
using EdFi.Roster.Sdk.Api.Resources;
using EdFi.Roster.Sdk.Models.Resources;
using Newtonsoft.Json;
using DeletedResource = EdFi.Roster.Sdk.Models.Resources.DeletedResource;

namespace EdFi.Roster.ChangeQueries.Services
{
    public class SectionService
    {
        private readonly IDataService _dataService;
        private readonly ApiService _apiService;
        private readonly ChangeQueryService _changeQueryService;

        public SectionService(IDataService dataService
            , ApiService apiService
            , ChangeQueryService changeQueryService)
        {
            _dataService = dataService;
            _apiService = apiService;
            _changeQueryService = changeQueryService;
        }

        public async Task<IEnumerable<EdFiSection>> ReadAllAsync()
        {
            var sections = await _dataService.ReadAllAsync<RosterSectionResource>();
            return sections.Select(section => JsonConvert.DeserializeObject<EdFiSection>(section.Content)).ToList();
        }

        public async Task<DataSyncResponseModel> RetrieveAndSyncSections(long minVersion, long maxVersion)
        {
            var queryParams = new Dictionary<string, string> { { "minChangeVersion", minVersion.ToString() },
                { "maxChangeVersion", maxVersion.ToString() } };

            var response =
                await _apiService.GetAllResources<SectionsApi, EdFiSection>(
                    $"{ApiRoutes.SectionsResource}", queryParams,
                    async (api, offset, limit) =>
                        await api.GetSectionsWithHttpInfoAsync(
                            offset, limit, (int?)minVersion, (int?)maxVersion));

            // Sync retrieved records to local db
            var sections = response.FullDataSet.Select(section =>
                new RosterSectionResource { Content = JsonConvert.SerializeObject(section), ResourceId = section.Id }).ToList();
            var addedRecords = await _dataService.AddOrUpdateAllAsync(sections);

            var deletesResponse =
                await _apiService.GetAllResources<SectionsApi, DeletedResource>(
                    $"{ApiRoutes.SectionsResource}/deletes", queryParams,
                    async (api, offset, limit) =>
                        await api.DeletesSectionsWithHttpInfoAsync(
                            offset, limit, (int?)minVersion, (int?)maxVersion));

            // Sync deleted records to local db
            var deletedSectionsCount = 0;
            if (deletesResponse.FullDataSet.Any())
            {
                var deletedSections = deletesResponse.FullDataSet.Select(section => section.Id).ToList();
                await _dataService.DeleteAllAsync<RosterSectionResource>(deletedSections);
                deletedSectionsCount = deletedSections.Count;
            }

            // Save latest change version 
            await _changeQueryService.Save(maxVersion, ResourceTypes.Sections);

            return new DataSyncResponseModel
            {
                ResourceName = ResourceTypes.Sections,
                AddedRecordsCount = addedRecords,
                UpdatedRecordsCount = response.FullDataSet.Count - addedRecords,
                DeletedRecordsCount = deletedSectionsCount
            };
        }
    }
}
