using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CardPinRegistry")]
    public class CardPinRegistry : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int PinNumber { get; set; }

        [DataMember]
        public CardPinType PinType { get; set; }
    }
}
