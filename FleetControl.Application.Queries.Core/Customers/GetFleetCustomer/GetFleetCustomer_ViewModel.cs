using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomer_ViewModel : QueryViewModel
    {
        public GetFleetCustomer_Dto Customer { get; set; }

        public GetFleetCustomer_ViewModel(int recordCount, string previousPage, string nextPage, GetFleetCustomer_Dto customer) : base(recordCount, previousPage, nextPage)
        {
            Customer = Customer;
        }
    }
}
