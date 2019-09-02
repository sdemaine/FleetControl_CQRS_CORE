using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Cards.GetFleetCardQueryable
{
    public class GetFleetCardQueryable_VehicleDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string TheirVehicleNumber { get; set; }

        public string VehicleDescription { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Vehicle, GetFleetCardQueryable_VehicleDto>()

                ;
        }
    }
}
