using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriverQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetDriverQueryable_Dto> Drivers { get; }

        public GetFleetDriverQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetDriverQueryable_Dto> drivers) : base(recordCount, previousPage, nextPage)
        {
            Drivers = drivers;
        }
    }

    
}
