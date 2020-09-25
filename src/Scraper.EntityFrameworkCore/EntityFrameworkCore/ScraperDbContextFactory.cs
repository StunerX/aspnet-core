using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Scraper.Configuration;
using Scraper.Web;

namespace Scraper.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ScraperDbContextFactory : IDesignTimeDbContextFactory<ScraperDbContext>
    {
        public ScraperDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ScraperDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ScraperDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ScraperConsts.ConnectionStringName));

            return new ScraperDbContext(builder.Options);
        }
    }
}
