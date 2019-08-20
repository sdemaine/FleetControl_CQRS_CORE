using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("LocationPricingLocationGroup")]
    public class LocationPricingLocationGroup : EntityBase
    {
        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public virtual Location Location { get; set; }

        [DataMember]
        public int? PricingLocationGroupId { get; set; }

        [DataMember]
        public virtual PricingLocationGroup PricingLocationGroup { get; set; }

        [DataMember]
        public DateTime FromDate { get; set; }

        [DataMember]
        public DateTime? ToDate { get; set; }
    }
}
