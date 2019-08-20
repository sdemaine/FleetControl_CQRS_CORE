using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("CardAddress")]
    public class CardAddress : EntityBase
    {
        [DataMember]
        [MaxLength(50)]
        public string NickName { get; set; }

        [DataMember]
        public int ExternalAddressId { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        [MaxLength(75)]
        public string AddressLine1 { get; set; }

        [DataMember]
        [MaxLength(75)]
        public string AddressLine2 { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string City { get; set; }

        [DataMember]
        [MaxLength(2)]
        public string State { get; set; }

        [DataMember]
        [MaxLength(9)]
        public string ZipCode { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [DataMember]
        public StatusMode Status { get; set; }
    }
}
