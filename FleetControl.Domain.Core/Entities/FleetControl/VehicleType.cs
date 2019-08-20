using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    public class VehicleType : EntityBase
    {
        [DataMember]
        [Column("VehicleType")]
        [MaxLength(2)]
        public string Value { get; set; }

        [DataMember]
        [Column("VehicleTypeDesc")]
        [MaxLength(30)]
        public string Text { get; set; }
    }
}
