using FleetControl.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("SiteCustomers")]
    public class SiteCustomer : EntityBase
    {
        [DataMember]
        [Column("CustNo")]
        [MaxLength(5)]
        public string CustomerNumber{ get; set; }

        [DataMember]
        [Column("DeviceNo")]
        [MaxLength(7)]
        public string DeviceNumber { get; set; }

        [DataMember]
        [MaxLength(1)]
        public string CardPrefix { get; set; }
    }
}
