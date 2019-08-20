using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("AuditDataType")]
    public class AuditDataType : EntityBase
    {
        [DataMember]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [DataMember]
        [MaxLength(100)]
        public string KeyDataType { get; set; }

        [DataMember]
        [Required]
        [MaxLength(100)]
        public string ValueDataType { get; set; }

        [DataMember]
        [MaxLength(100)]
        public string KeyCaption { get; set; }

        [DataMember]
        [Required]
        [MaxLength(100)]
        public string ValueCaption { get; set; }

        [DataMember]
        [MaxLength(100)]
        public string KeyTable { get; set; }

    }
}
