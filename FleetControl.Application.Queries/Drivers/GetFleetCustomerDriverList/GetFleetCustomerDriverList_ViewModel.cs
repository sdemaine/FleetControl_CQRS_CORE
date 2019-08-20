using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetCustomerDriverList_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetCustomerDriverList_ViewDto> Drivers { get; }

        public GetFleetCustomerDriverList_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetCustomerDriverList_ViewDto> drivers) : base(recordCount, previousPage, nextPage)
        {
            Drivers = drivers;
        }
    }
}
