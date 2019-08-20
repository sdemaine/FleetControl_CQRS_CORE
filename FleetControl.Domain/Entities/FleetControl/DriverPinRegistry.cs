using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("DriverPinRegistry")]
    public class DriverPinRegistry : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int PinNumber { get; set; }
    }
}
