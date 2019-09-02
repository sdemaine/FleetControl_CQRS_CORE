using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Customers
{
    public class GetCustomerQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetCustomerQueryable_Dto>>, IHaveCustomMapping
    {
        public GetCustomerQueryable_Query()
        {

        }

        public GetCustomerQueryable_Query(QueryRequestModel queryRequestModel, IMapper mapper)
        {
            mapper.Map(queryRequestModel, this);
        }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<QueryRequestModel, GetCustomerQueryable_Query>();
        }
    }
}
