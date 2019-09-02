using FleetControl.Application.Interfaces.Mapping;
using FleetControl.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Common
{
    public abstract class EntityListQuery
    {
        public QueryRequestModel QueryRequest { get; }


        public EntityListQuery(QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
        }

    }
}
