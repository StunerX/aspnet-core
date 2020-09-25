using System.Threading.Tasks;
using Scraper.Models.TokenAuth;
using Scraper.Web.Controllers;
using Shouldly;
using Xunit;

namespace Scraper.Web.Tests.Controllers
{
    public class HomeController_Tests: ScraperWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}