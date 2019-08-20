using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Domain;
using System;

namespace FleetControl.Application.Queries
{
    public class CardClassDto : IHaveCustomMapping
    {
        public string Class { get; set; }

        public string Description { get; set; }

        public double MaxFuel { get; set; }

        public double MinRange { get; set; }

        public double MaxRange { get; set; }

        public int? ProductId { get; set; }

        public string ProductsNotAllowed { get; set; }

        public DateTime? LastUpdated { get; set; }

        public int? AccountNumber { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<CardClass, CardClassDto>()
                //.ForMember(cDTO => cDTO.LastUpdated, opt => opt.Ignore())
                //.ForMember(cDTO => cDTO.ProductId, opt => opt.MapFrom(c => c.ProductId))
                //.ForMember(cDTO => cDTO.Name, opt => opt.MapFrom(c => c.CompanyName)
               ;
        }
    }
}
