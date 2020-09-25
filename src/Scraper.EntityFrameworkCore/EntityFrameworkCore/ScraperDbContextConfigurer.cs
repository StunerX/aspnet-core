using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Scraper.EntityFrameworkCore
{
    public static class ScraperDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ScraperDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ScraperDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
