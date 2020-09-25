using System.Threading.Tasks;
using Abp.Application.Services;
using Scraper.Sessions.Dto;

namespace Scraper.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
