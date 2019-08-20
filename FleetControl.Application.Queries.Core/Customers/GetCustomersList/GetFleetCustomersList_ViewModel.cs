using System.Collections.Generic;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomersList_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetCustomerList_Dto> Customers { get; }

        public GetFleetCustomersList_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetCustomerList_Dto> customers) : base(recordCount, previousPage, nextPage)
        {
            Customers = customers;
        }
    }
}
