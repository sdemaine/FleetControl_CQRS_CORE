using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.BusinessHours
{
    public class GetBusinessHoursQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetBusinessHoursQueryable_Dto> BusinessHours { get; }

        public GetBusinessHoursQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetBusinessHoursQueryable_Dto> businessHours) : base(recordCount, previousPage, nextPage)
        {
            BusinessHours = businessHours;
        }
    }

    
}
