using System.IO;
using System.Threading.Tasks;
using EdFi.Common;
using EdFi.Roster.Sdk.Client;

namespace EdFi.Roster.ChangeQueries.Services
{
    public class ChangeQueriesConfigurationService : IConfigurationService
    {
        private readonly ApiSettingsService _apiSettingsService;
        private readonly BearerTokenService _bearerTokenService;

        public ChangeQueriesConfigurationService(ApiSettingsService apiSettingsService,
            BearerTokenService bearerTokenService)
        {
            _apiSettingsService = apiSettingsService;
            _bearerTokenService = bearerTokenService;
        }

        public async Task<Configuration> ApiConfiguration(bool refreshToken = false, bool isChangeQueries = false)
        {
            var apiSettings = await _apiSettingsService.Read();
            var token = await _bearerTokenService.GetBearerToken(apiSettings, refreshToken);

            var urlRoute = "data/v3";
            if (isChangeQueries)
            {
                urlRoute = "ChangeQueries/v1";
            }

            return new Configuration
            {
                AccessToken = token,
                BasePath = Path.Combine(apiSettings.RootUrl, urlRoute)
            };
        }
    }
}
