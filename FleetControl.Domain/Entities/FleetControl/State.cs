using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("State")]
    public class State : EntityBase
    {
        [DataMember]
        [Column("State")]
        [MaxLength(2)]
        public string StateCode { get; set; }

        [DataMember]
        [Column("Description")]
        [MaxLength(30)]
        public string Description { get; set; }

        [DataMember]
        [Column("TaxArea")]
        [MaxLength(2)]
        public string TaxArea { get; set; }
    }
}
