using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("FuelManagementGroup")]
    public class FuelManagementGroup : EntityBase
    {
        [DataMember]
        [Column("FMRGroup")]
        [MaxLength(3)]
        public string FMRGroup { get; set; }    //.. PK

        [DataMember]
        [Column("Description")]
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
