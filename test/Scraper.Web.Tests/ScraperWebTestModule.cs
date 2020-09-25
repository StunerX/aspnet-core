using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Scraper.EntityFrameworkCore;
using Scraper.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Scraper.Web.Tests
{
    [DependsOn(
        typeof(ScraperWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ScraperWebTestModule : AbpModule
    {
        public ScraperWebTestModule(ScraperEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ScraperWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ScraperWebMvcModule).Assembly);
        }
    }
}