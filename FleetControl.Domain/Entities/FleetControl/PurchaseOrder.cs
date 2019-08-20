using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("PurchaseOrder")]
    public class PurchaseOrder : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int ShipTo { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int RequiredAdvance { get; set; }

        [DataMember]
        public double? TotalAmount { get; set; }

        [DataMember]
        [MaxLength(30)]
        public string PurchaseOrderNumber { get; set; }

        [DataMember]
        public DateTime EffectiveDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }
    }
}
