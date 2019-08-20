using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("MasterGroups")]
    public class MasterGroup : EntityBase
    {
        [DataMember]
        [Column("MasterGroupCode")]
        [MaxLength(3)]
        public string MasterGroupCode { get; set; }

        [DataMember]
        [Column("MasterGroupDesc")]
        [MaxLength(30)]
        public string MasterGroupDescription { get; set; }

        [DataMember]
        [Column("MasterGroupSumCode")]
        [MaxLength(3)]
        public string MasterGroupSumCode { get; set; }
    }
}
