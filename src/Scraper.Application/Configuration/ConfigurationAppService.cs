using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Scraper.Configuration.Dto;

namespace Scraper.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ScraperAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
