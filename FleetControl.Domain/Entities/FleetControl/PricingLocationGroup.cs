using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("PricingLocationGroup")]
    public class PricingLocationGroup : EntityBase
    {
        [DataMember]
        public int? PricingLocationGroupCode { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string PricingLocationGroupName { get; set; }

        [DataMember]
        public BooleanEnum IsRetail { get; set; }
    }
}
