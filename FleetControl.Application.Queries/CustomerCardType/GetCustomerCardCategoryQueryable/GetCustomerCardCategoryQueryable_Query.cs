using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetCustomerCardCategoryQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetCustomerCardCategoryQueryable_Dto>>
    {
        public QueryRequestModel QueryRequestModel { get; }

        public GetCustomerCardCategoryQueryable_Query(QueryRequestModel queryRequestModel)
        {
            QueryRequestModel = queryRequestModel;
        }
    }
}
