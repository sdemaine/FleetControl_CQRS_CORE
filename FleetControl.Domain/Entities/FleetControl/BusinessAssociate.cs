using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("BusinessAssociate")]
    public class BusinessAssociate : EntityBase
    {
        [DataMember]
        public int BAID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string AbbreviatedName { get; set; }

        [DataMember]
        public bool IsFleetControlBAID { get; set; }
    }
}
