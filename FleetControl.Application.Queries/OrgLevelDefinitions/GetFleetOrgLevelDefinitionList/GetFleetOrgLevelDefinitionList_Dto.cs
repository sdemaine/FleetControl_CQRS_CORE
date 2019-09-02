using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using FleetControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.OrgLevelDefinitions.GetFleetOrgLevelDefinitionList
{
    public class GetFleetOrgLevelDefinitionList_Dto : IHaveCustomMapping
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public int? BillToLocation { get; set; }

        public int? ShipToLocation { get; set; }

        public int? ParentId { get; set; }

        public int? OrgId { get; set; }

        public int LevelDepth { get; set; }

        public int CustomerId { get; set; }

        public string CustomerDepartmentNumber { get; set; }

        public bool Active { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<OrgLevelDefinition, GetFleetOrgLevelDefinitionList_Dto>();
        }
    }
}
