using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("SolArcProduct")]
    public class SolarcProduct : EntityBase
    {
        [DataMember]
        //[MaxLength(4)]
        public int ProductId { get; set; }

        [DataMember]
        [MaxLength(1)]
        public string ProductStatus { get; set; }

        [DataMember]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [DataMember]
        [MaxLength(3)]
        public string ProductAbbreviation { get; set; }
    }
}
