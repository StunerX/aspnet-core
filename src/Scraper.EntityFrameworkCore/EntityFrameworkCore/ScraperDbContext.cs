using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Scraper.Authorization.Roles;
using Scraper.Authorization.Users;
using Scraper.MultiTenancy;
using Scraper.CarAdvertisements;

namespace Scraper.EntityFrameworkCore
{
    public class ScraperDbContext : AbpZeroDbContext<Tenant, Role, User, ScraperDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<CarAdvertisement> CarAdvertisements { get; set; }

        public ScraperDbContext(DbContextOptions<ScraperDbContext> options)
            : base(options)
        {
        }
    }
}
