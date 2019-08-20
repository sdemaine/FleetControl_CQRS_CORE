using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("DTProperties")]
    public class DTProperties : EntityBase
    {
        [DataMember]
        [Column("ObjectId")]
        public int ObjectId { get; set; }

        [DataMember]
        [Column("Property")]
        [MaxLength(64)]
        public string Property { get; set; }

        [DataMember]
        [Column("Value")]
        [MaxLength(255)]
        public string Value { get; set; }

        [DataMember]
        //.. [Column("IValue")]
        [Column(TypeName="image")]
        public byte[] IValue { get; set; } //.. need to represent image

        [DataMember]
        [Column("Version")]
        public int Version { get; set; }

        [DataMember]
        [Column("UValue")]
        [MaxLength(255)]
        public string UValue { get; set; }
    }
}
