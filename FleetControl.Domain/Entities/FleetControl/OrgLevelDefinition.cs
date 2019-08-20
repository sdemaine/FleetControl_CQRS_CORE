using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("OrgLevelDefinition")]
    public class OrgLevelDefinition : EntityBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        [MaxLength(25, ErrorMessage = "The 'Display Name' value cannot exceed 25 characters.")]
        public string DisplayName { get; set; }

        [DataMember]
        public int? BillToLocation { get; set; }

        [DataMember]
        public int? ShipToLocation { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public int? OrgId { get; set; }

        [DataMember]
        public int LevelDepth { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string CustomerDepartmentNumber { get; set; }

        [DataMember]
        public bool Active { get; set; }
    }
}
