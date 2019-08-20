using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("AuditEvent")]
    public class AuditEvent : EntityBase
    {
        [DataMember]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
