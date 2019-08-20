using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Domain;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerLookup_Model : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Customer, GetFleetCustomerLookup_Model>()
                .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.Id))
                .ForMember(cDTO => cDTO.Name, opt => opt.MapFrom(c => c.CustomerName));

            configuration.CreateMap<Customer, GetFleetCustomer_ViewModel>();

            
        }
    }
}
