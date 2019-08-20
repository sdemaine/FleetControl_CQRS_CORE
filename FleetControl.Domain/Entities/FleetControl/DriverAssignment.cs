using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetControl.Domain
{
    [Table("DriverAssignment")]
    public class DriverAssignment : EntityBase
    {
        [MaxLength(50)]
        public string AccountNumber { get; set; }

        [MaxLength(20)]
        public string DriverId { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
    }
}
