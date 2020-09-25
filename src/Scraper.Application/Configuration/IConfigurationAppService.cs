using System.Threading.Tasks;
using Scraper.Configuration.Dto;

namespace Scraper.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
