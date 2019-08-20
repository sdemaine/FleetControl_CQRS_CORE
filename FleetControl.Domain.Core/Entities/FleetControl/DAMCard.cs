using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("DAMCard")]
    public class DAMCard : EntityBase
    {
        [DataMember]
        [Column("EntityType")]
        public CardEntityType EntityType { get; set; }

        [DataMember]
        public int EntityId { get; set; }

        [DataMember]
        public DAMAction DAMAction { get; set; }

        [DataMember]
        public DAMStatus DAMStatus { get; set; }

        [DataMember]
        public CardStatusIndicator? DAMCardStatusIndicator { get; set; }

        [DataMember]
        public int HasDataChange { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [DataMember]
        public int ControlNumber { get; set; }

        [DataMember]
        public int SequenceNumber { get; set; }

        [DataMember]
        public string ErrorCode1 { get; set; }

        [DataMember]
        public string ErrorCode2 { get; set; }

        [DataMember]
        public string ErrorCode3 { get; set; }

        [DataMember]
        public string ErrorCode4 { get; set; }

        [DataMember]
        public string ErrorCode1Description { get; set; }

        [DataMember]
        public string ErrorCode2Description { get; set; }

        [DataMember]
        public string ErrorCode3Description { get; set; }

        [DataMember]
        public string ErrorCode4Description { get; set; }

        [DataMember]
        public int CardId { get; set; }

        [ForeignKey("EntityId")]
        [DataMember]
        public virtual Card Card { get; set; }
    }
}
