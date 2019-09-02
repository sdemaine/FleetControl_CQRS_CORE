using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Samples.GetSampleQueryable
{
    public class GetSampleQueryable_Dto : IHaveCustomMapping
    {
        
        public string Property1 { get; set; }

        public string Property2 { get; set; }

        

        public void CreateMappings(Profile configuration)
        {
            //configuration.CreateMap<Sample, GetSampleQueryable_Dto>();
        }
    }
}
