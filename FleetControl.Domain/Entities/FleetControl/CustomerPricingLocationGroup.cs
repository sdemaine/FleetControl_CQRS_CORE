using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustomerPricingLocationGroup")]
    public class CustomerPricingLocationGroup : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int PricingLocationGroupId { get; set; }

        [DataMember]
        public int? PriceServiceId { get; set; }

        [DataMember]
        public DateTime FromDate { get; set; }

        [DataMember]
        public DateTime? ToDate { get; set; }
    }
}
