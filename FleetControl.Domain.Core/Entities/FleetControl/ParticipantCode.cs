using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("ParticipantCode")]
    public class ParticipantCode : EntityBase
    {
        [DataMember]
        [MaxLength(5)]
        public string Code { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string BrandName { get; set; }
    }
}
