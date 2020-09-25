using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using Scraper.CarAdvertisements.Dtos;
using Scraper.CarAdvertisements.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Scraper.CarAdvertisements
{
    public class CarAdvertisementAppService
        : AsyncCrudAppService<CarAdvertisement, CarAdvertisementDto, Guid, GetAllInput>
        , ICarAdvertisementAppService
    {
        public CarAdvertisementAppService(IRepository<CarAdvertisement, Guid> repository) : base(repository)
        {
        }

        public async Task Insert(CarAdvertisement input)
        {
            await base.Repository.InsertAsync(input);
        }
        public async Task<CarAdvertisementDto> GetByLink(string link)
        {
            var car = await CreateFilteredQuery(new GetAllInput() { Link = link }).FirstOrDefaultAsync();
            return ObjectMapper.Map<CarAdvertisementDto>(car);
        }

        protected override IQueryable<CarAdvertisement> CreateFilteredQuery(GetAllInput input)
        {
            return base.CreateFilteredQuery(input)
                .WhereIf(!string.IsNullOrEmpty(input.Link), c => c.Link == input.Link.Trim());
        }
    }
}
