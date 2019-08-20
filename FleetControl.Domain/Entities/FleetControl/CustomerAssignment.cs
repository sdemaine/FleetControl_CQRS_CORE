using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("CustomerAssignment")]
    public class CustomerAssignment : EntityBase
    {
        [DataMember]
        public int UserProfileId { get; set; }

        [DataMember]
        public int BAID { get; set; }
    }
}
