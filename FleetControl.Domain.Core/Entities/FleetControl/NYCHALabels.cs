using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("NYCHALabels")]
    public class NYCHALabels : EntityBase
    {
        [DataMember]
        [Column("CustomerNumber")]
        [MaxLength(5)]
        public string CustomerNumber { get; set; }

        [DataMember]
        [Column("GroupNumber")]
        [MaxLength(5)]
        public string GroupNumber { get; set; }

        [DataMember]
        [Column("AttnTo")]
        [MaxLength(30)]
        public string AttnTo { get; set; }

        [DataMember]
        [Column("Address")]
        [MaxLength(30)]
        public string Address { get; set; }

        [DataMember]
        [Column("City")]
        [MaxLength(24)]
        public string City { get; set; }

        [DataMember]
        [Column("State")]
        [MaxLength(2)]
        public string State { get; set; }

        [DataMember]
        [Column("ZipCode")]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [DataMember]
        [Column("Description")]
        [MaxLength(40)]
        public string Description { get; set; }
    }
}
