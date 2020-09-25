using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Scraper.Controllers
{
    public abstract class ScraperControllerBase: AbpController
    {
        protected ScraperControllerBase()
        {
            LocalizationSourceName = ScraperConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
