using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustomerGroupDetail")]
    public class CustomerGroupDetail : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        public int CustomerGroupId { get; set; }

        [DataMember]
        public virtual CustomerGroup CustomerGroup { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}
