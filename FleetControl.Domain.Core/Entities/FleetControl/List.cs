using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("List")]
    public class List : EntityBase
    {
        [DataMember]
        [Column("List")]
        [MaxLength(5)]
        public string ListCode { get; set; }

        [DataMember]
        [Column("Description")]
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
