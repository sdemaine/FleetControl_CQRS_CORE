using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustomerPricingLocationWorkEntry")]
    public class CustomerPricingLocationWorkEntry : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int LocationId { get; set; }
    }
}
