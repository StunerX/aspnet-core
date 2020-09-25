using System.Threading.Tasks;
using Abp.Application.Services;
using Scraper.Authorization.Accounts.Dto;

namespace Scraper.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
