using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Locations.GetLocationQueryable
{
    public class GetLocationQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetLocationQueryable_Dto> Locations { get; }

        public GetLocationQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetLocationQueryable_Dto> locations) : base(recordCount, previousPage, nextPage)
        {
            Locations = locations;
        }
    }
}
