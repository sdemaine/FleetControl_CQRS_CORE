using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using MediatR;
using System.Collections.Generic;

namespace FleetControl.Application.Queries.Transactions
{
    public class GetTransactionsQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetTransactionsQueryable_Dto>>, IHaveCustomMapping
    {

        public GetTransactionsQueryable_Query()
        {

        }

        public GetTransactionsQueryable_Query(QueryRequestModel queryRequestModel, IMapper mapper)
        {
            mapper.Map(queryRequestModel, this);
        }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<QueryRequestModel, GetTransactionsQueryable_Query>();
        }
    }
}
