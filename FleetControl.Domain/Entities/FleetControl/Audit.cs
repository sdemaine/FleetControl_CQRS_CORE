using FleetControl.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("Audit")]
    public class Audit : EntityBase
    {
        [DataMember]
        [Required]
        public int AuditEventId { get; set; }

        [DataMember]
        public virtual AuditEvent AuditEvent { get; set; }

        [DataMember]
        public virtual ICollection<AuditDetail> AuditDetails { get; set; }
    }
}
