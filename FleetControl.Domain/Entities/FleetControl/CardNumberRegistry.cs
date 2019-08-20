using FleetControl.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("CardNumberRegistry")]
    public class CardNumberRegistry : EntityBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string CardNumber { get; set; }

        [DataMember]
        public CardType CardType { get; set; }
    }
}
