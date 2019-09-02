using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.CardShipmentAddress
{
    public class GetCardShipmentAddressQueryable_Dto : IHaveCustomMapping
    {
        public string NickName { get; set; }

        public int ExternalAddressId { get; set; }

        public int CustomerId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public StatusMode Status { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<CardAddress, GetCardShipmentAddressQueryable_Dto>()
                ;
        }
    }
}
