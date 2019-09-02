using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetCustomerCardCategoryQueryable_Dto : IHaveCustomMapping
    {
        public int CustomerId { get; set; }

        public int CardCategoryId { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<CustomerCardCategory, GetCustomerCardCategoryQueryable_Dto>()
                ;
        }
    }
}
