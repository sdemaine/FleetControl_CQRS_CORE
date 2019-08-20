using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("AuditDetail")]
    public class AuditDetail : EntityBase
    {
        [DataMember]
        [Required]
        public int AuditId { get; set; }

        [DataMember]
        public virtual Audit Audit { get; set; }

        [DataMember]
        [Required]
        public int AuditDataTypeId { get; set; }

        [DataMember]
        public virtual AuditDataType AuditDataType { get; set; }

        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string Value { get; set; }
    }
}
