using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustomerStateLocation")]
    public class CustomerStateLocation : EntityBase
    {
        [DataMember]
        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        [Column("StateId")]
        public int StateId { get; set; }

        [DataMember]
        public virtual State State { get; set; }
    }
}
