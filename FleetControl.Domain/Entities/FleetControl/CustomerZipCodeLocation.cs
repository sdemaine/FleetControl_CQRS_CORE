using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CustomerZipCodeLocation")]
    public class CustomerZipCodeLocation : EntityBase
    {
        [DataMember]
        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [DataMember]
        public virtual Customer Customer { get; set; }

        [DataMember]
        [Column("ZipCode")]
        public int ZipCode { get; set; }
    }
}
