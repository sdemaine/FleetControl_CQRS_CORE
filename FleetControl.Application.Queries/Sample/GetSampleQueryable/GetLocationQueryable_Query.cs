using DevExtreme.AspNet.Mvc;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Samples.GetSampleQueryable
{
    public class GetSampleQueryable_Query : IRequest<IEnumerable<GetSampleQueryable_Dto>>
    {
        public QueryRequestModel QueryRequestModel { get; }

        public GetSampleQueryable_Query(QueryRequestModel queryRequestModel)
        {
            QueryRequestModel = queryRequestModel;
        }
    }
}
