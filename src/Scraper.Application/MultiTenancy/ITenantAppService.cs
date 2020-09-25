using Abp.Application.Services;
using Scraper.MultiTenancy.Dto;

namespace Scraper.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

