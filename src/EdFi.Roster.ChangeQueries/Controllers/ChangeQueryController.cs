using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EdFi.Roster.ChangeQueries.Models;
using EdFi.Roster.ChangeQueries.Services;
using EdFi.Roster.ChangeQueries.Services.ApiSdk;

namespace EdFi.Roster.ChangeQueries.Controllers
{
    public class ChangeQueryController : Controller
    {
        private readonly ChangeQueryService _changeQueryService;
        private readonly LocalEducationAgencyService _localEducationAgencyService;
        private readonly StudentService _studentService;
        private readonly SchoolService _schoolService;
        private readonly SectionService _sectionService;
        private readonly StaffService _staffService;

        public ChangeQueryController(ChangeQueryService changeQueryService
        , LocalEducationAgencyService localEducationAgencyService
        , StudentService studentService
        , SchoolService schoolService
        , SectionService sectionService
        , StaffService staffService)
        {
            _changeQueryService = changeQueryService;
            _localEducationAgencyService = localEducationAgencyService;
            _studentService = studentService;
            _schoolService = schoolService;
            _sectionService = sectionService;
            _staffService = staffService;
        }

        public async Task<IActionResult> Index()
        {
            var availableVersion = await _changeQueryService.GetAvailableVersionAsync();
            var currentVersions = await _changeQueryService.ReadCurrentVersionsForResourcesAsync();

            var changeQueryModel = new ChangeQueryViewModel
            {
                ChangeSummaryMessage = "No pending changes to sync. Please come back later for updates."
            };


            if (currentVersions.Count < ResourceTypes.ResourceTypeCount() || currentVersions.Select(x => x.ChangeVersion).Any(x => x < availableVersion))
            {
                changeQueryModel.ChangeSummaryMessage = "There are pending changes to sync. Please click the Sync button to update your records.";
            }

            return View(changeQueryModel);
        }

        public async Task<IActionResult> SyncData()
        {
            var availableVersion = await _changeQueryService.GetAvailableVersionAsync();
            var responses = new List<DataSyncResponseModel>
            {
                await RunRetrieveAndSyncService(ResourceTypes.LocalEducationAgencies, availableVersion),
                await RunRetrieveAndSyncService(ResourceTypes.Schools, availableVersion),
                await RunRetrieveAndSyncService(ResourceTypes.Staff, availableVersion),
                await RunRetrieveAndSyncService(ResourceTypes.Students, availableVersion),
                await RunRetrieveAndSyncService(ResourceTypes.Sections, availableVersion)
            };

            var changeQueryModel = new ChangeQueryViewModel
            {
                ChangeSummaryMessage = "Please find sync status for individual resources.",
                SyncResponses = responses
            };
            return View("Index", changeQueryModel);
        }

        private async Task<DataSyncResponseModel> RunRetrieveAndSyncService(string resourceType, long availableVersion)
        {
            var noChangesMessage = "No pending changes to sync for ";
            var currentVersions = await _changeQueryService.ReadCurrentVersionsForResourcesAsync();
            var changeVersion =
                currentVersions.SingleOrDefault(x => x.ResourceType == resourceType);
            var minVersion = changeVersion?.ChangeVersion ?? 0;

            DataSyncResponseModel response = null;
            if (minVersion >= availableVersion)
            {
                response = new DataSyncResponseModel
                {
                    ResourceName = $"{noChangesMessage}{resourceType}"
                };
            }
            else
            {
               
                response = resourceType switch
                {
                    ResourceTypes.LocalEducationAgencies =>
                        await _localEducationAgencyService.RetrieveAndSyncLocalEducationAgencies(minVersion,
                            availableVersion),
                    ResourceTypes.Schools => await _schoolService.RetrieveAndSyncSchools(minVersion, availableVersion),
                    ResourceTypes.Staff => await _staffService.RetrieveAndSyncStaff(minVersion, availableVersion),
                    ResourceTypes.Students => await _studentService.RetrieveAndSyncStudents(minVersion, availableVersion),
                    ResourceTypes.Sections => await _sectionService.RetrieveAndSyncSections(minVersion, availableVersion),
                    _ => response
                };
            }
            return response;
        }
    }
}
