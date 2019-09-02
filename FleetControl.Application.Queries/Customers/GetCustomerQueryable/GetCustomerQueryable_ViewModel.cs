using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Customers
{
    public class GetCustomerQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetCustomerQueryable_Dto> Customers { get; }

        public GetCustomerQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetCustomerQueryable_Dto> customers) : base(recordCount, previousPage, nextPage)
        {
            Customers = customers;
        }
    }

    
}
