using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries
{
    public class DriverDto : IHaveCustomMapping
    {
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Driver, DriverDto>()
               //.ForMember(cDTO => cDTO.LastUpdated, opt => opt.Ignore())
               //.ForMember(cDTO => cDTO.ProductId, opt => opt.MapFrom(c => c.ProductId))
               //.ForMember(cDTO => cDTO.Name, opt => opt.MapFrom(c => c.CompanyName)
               ;
        }
    }
}
