using Abp.Application.Services.Dto;

namespace Scraper.CarAdvertisements.Dtos
{
    public class GetAllInput : PagedAndSortedResultRequestDto
    {
        public string Link { get; set; }
    }
}
