using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("SPR_CreateFleetRecExceptions")]
    public class SPR_CreateFleetRecExceptions : EntityBase
    {
        [DataMember]
        [Column("BillingWeek")]
        [MaxLength(6)]
        public string BillingWeek { get; set; }

        [DataMember]
        [Column("FleetTranNo")]
        [MaxLength(10)]
        public string FleetTranNo { get; set; }

        [DataMember]
        [Column("ImportValue")]
        [MaxLength(20)]
        public string ImportValue { get; set; }

        [DataMember]
        [Column("GasCardValue")]
        [MaxLength(20)]
        public string GasCardValue { get; set; }

        [DataMember]
        [Column("ErrorDesc")]
        [MaxLength(200)]
        public string ErrorDescription { get; set; }
    }
}
