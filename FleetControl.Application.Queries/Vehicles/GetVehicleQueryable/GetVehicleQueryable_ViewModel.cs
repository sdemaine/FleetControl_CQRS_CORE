using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Vehicles
{
    public class GetVehicleQueryable_ViewModel : QueryViewModel
    {
        public IEnumerable<GetVehicleQueryable_Dto> Vehicles { get; }

        public GetVehicleQueryable_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetVehicleQueryable_Dto> vehicles) : base(recordCount, previousPage, nextPage)
        {
            Vehicles = vehicles;
        }
    }

    
}
