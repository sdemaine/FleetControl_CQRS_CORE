using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("ExternalDatabase")]
    public class ExternalDatabase : EntityBase
    {
        [DataMember]
        [MaxLength(50)]
        public string DatabaseName { get; set; }

        [DataMember]
        [MaxLength(1000)]
        public string Path { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string ProcessorPath { get; set; }

        [DataMember]
        public string ProcessorName { get; set; }

        [DataMember]
        public SourceSystem SourceSystem { get; set; }
    }
}
