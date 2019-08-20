
using FleetControl.Core;

namespace FleetControl.Domain
{
    public class DAMVehicleMaintenanceDetail : EntityBase
    {
        public int Id { get; set; }

        public DAMVehicle DAMVehicle { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
