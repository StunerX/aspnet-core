using Abp.Application.Services;
using System;
using System.Threading.Tasks;

namespace Scraper.ICarros.Interfaces
{
    public interface IICarrosAppService : IApplicationService
    {
        public Task<Guid> Search();
    }
}
