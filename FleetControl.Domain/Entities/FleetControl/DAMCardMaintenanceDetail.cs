
using FleetControl.Core;

namespace FleetControl.Domain
{
    public class DAMCardMaintenanceDetail : EntityBase
    {
        public int Id { get; set; }

        public DAMCard DAMCard { get; set; }

        public Card Card { get; set; }
    }
}
