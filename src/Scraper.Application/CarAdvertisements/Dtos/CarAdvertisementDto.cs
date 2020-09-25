using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace Scraper.CarAdvertisements.Dtos
{
    [AutoMapFrom(typeof(CarAdvertisement))]
    public class CarAdvertisementDto : AuditedEntityDto<Guid>
    {
        public string ExternalId { get; set; }
        public string Year { get; set; }
        public decimal KM { get; set; }
        public string Color { get; set; }
        public string Gear { get; set; }
        public int Door { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Info { get; set; }
        public string Link { get; set; }
        public string AuthorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Phones { get; set; }
        public string AuthorType { get; set; }
    }
}
