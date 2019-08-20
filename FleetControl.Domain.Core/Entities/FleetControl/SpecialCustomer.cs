using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("SpecialCustomer")]
    public class SpecialCustomer : EntityBase
    {
        [DataMember]
        [Column("SpecialCustomerCode")]
        [MaxLength(1)]
        public string Code { get; set; } //.. PK

        [DataMember]
        [Column("Description")]
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
