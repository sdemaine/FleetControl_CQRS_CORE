using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustomerMerchantLocation")]
    public class CustomerMerchantLocation : EntityBase
    {
        [DataMember]
        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        [Column("MerchantId")]
        public int MerchantId { get; set; }
    }
}
