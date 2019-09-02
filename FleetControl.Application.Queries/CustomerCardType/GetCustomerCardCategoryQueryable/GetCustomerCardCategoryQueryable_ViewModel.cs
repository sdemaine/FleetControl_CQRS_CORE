using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetCustomerCardCategoryQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetCustomerCardCategoryQueryable_Dto> Drivers { get; }

        public GetCustomerCardCategoryQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetCustomerCardCategoryQueryable_Dto> drivers) : base(recordCount, previousPage, nextPage)
        {
            Drivers = drivers;
        }
    }

    
}
