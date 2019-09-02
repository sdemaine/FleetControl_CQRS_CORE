using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.LocationPricingGroups
{
    public class PricingLocationGroupQueryable_Dto : IHaveCustomMapping
    {
        public int? PricingLocationGroupCode { get; set; }

        public string PricingLocationGroupName { get; set; }

        public BooleanEnum IsRetail { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PricingLocationGroup, PricingLocationGroupQueryable_Dto>()
                ;
        }
    }
}
