using Abp.Application.Services;
using Scraper.CarAdvertisements.Dtos;
using System;
using System.Threading.Tasks;

namespace Scraper.CarAdvertisements.Interfaces
{
    public interface ICarAdvertisementAppService : IAsyncCrudAppService<CarAdvertisementDto, Guid, GetAllInput>
    {
        public Task<CarAdvertisementDto> GetByLink(string link);
        public Task Insert(CarAdvertisement input);
    }
}
