using Abp.AspNetCore.Mvc.ViewComponents;

namespace Scraper.Web.Views
{
    public abstract class ScraperViewComponent : AbpViewComponent
    {
        protected ScraperViewComponent()
        {
            LocalizationSourceName = ScraperConsts.LocalizationSourceName;
        }
    }
}
