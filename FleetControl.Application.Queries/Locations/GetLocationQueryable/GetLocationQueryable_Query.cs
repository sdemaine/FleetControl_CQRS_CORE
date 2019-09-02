using DevExtreme.AspNet.Mvc;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Locations.GetLocationQueryable
{
    public class GetLocationQueryable_Query : IRequest<IEnumerable<GetLocationQueryable_Dto>>
    {
        public QueryRequestModel QueryRequestModel { get; }

        public GetLocationQueryable_Query(QueryRequestModel queryRequestModel)
        {
            QueryRequestModel = queryRequestModel;
        }
    }
}
