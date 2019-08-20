using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("Source")]
    public class Source : EntityBase
    {
        [DataMember]
        [MaxLength(5)]
        public string Code { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
