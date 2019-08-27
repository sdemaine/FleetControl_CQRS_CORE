using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriverQueryable_Query : IRequest<IEnumerable<GetFleetDriverQueryable_ViewDto>>
    {
        public int CustomerId { get; set; }
    }
}
