using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Domain;

namespace FleetControl.Application.Queries.OrgLevelDefinitions
{
    public class GetOrgLevelDefinitionsQueryable_Dto : IHaveCustomMapping
    {
        public int Id { get; set; }
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
            configuration.CreateMap<OrgLevelDefinition, GetOrgLevelDefinitionsQueryable_Dto>()
                ;
        }
    }
}
