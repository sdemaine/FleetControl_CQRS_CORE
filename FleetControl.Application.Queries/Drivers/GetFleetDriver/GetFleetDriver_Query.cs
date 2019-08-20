using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriver_Query : IRequest<GetFleetDriver_ViewModel>
    {
        public int DriverId { get; set; }
    }
}
