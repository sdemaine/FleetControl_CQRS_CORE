using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.BusinessHours
{
    public class GetBusinessHoursQueryable_Query : QueryRequestModel, IRequest<IEnumerable<GetBusinessHoursQueryable_Dto>>
    {
        public QueryRequestModel QueryRequestModel { get; }

        public GetBusinessHoursQueryable_Query(QueryRequestModel queryRequestModel)
        {
            QueryRequestModel = queryRequestModel;
        }
    }
}
