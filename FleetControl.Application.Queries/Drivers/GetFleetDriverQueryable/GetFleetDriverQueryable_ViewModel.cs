using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriverQueryable_ViewModel
    {
        public IEnumerable<GetFleetDriverQueryable_ViewDto> Drivers { get; set; }

        public int TotalCount { get; set; }

        public int GroupCount { get; set; }
    }
}
