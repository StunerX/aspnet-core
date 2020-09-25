using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Scraper.Controllers;

namespace Scraper.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ScraperControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
