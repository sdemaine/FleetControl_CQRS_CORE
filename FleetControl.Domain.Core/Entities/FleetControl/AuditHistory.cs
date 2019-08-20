using FleetControl.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("AuditHistory")]
    public class AuditHistory : EntityBase
    {
        [DataMember]
        [Required]
        public int AuditEventId { get; set; }

        [DataMember]
        public virtual AuditEvent AuditEvent { get; set; }

        [DataMember]
        public virtual ICollection<AuditHistoryDetail> AuditDetails { get; set; }
    }
}
