using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Cards
{
    public class GetFleetCardQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetFleetCardQueryable_Dto>>
    {
        public QueryRequestModel QueryRequestModel { get; }

        public GetFleetCardQueryable_Query(QueryRequestModel queryRequestModel)
        {
            QueryRequestModel = queryRequestModel;
        }
    }
}
