
using FleetControl.Core;

namespace FleetControl.Domain
{
    public class DAMDriverMaintenanceDetail : EntityBase
    {
        public int Id { get; set; }

        public DAMDriver DAMDriver { get; set; }

        public Driver Driver { get; set; }
    }
}
