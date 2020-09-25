using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Scraper.Authorization;

namespace Scraper
{
    [DependsOn(
        typeof(ScraperCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ScraperApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ScraperAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ScraperApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
