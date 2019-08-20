using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [DataContract]
    [Table("ExternalDatabaseDetail")]
    public class ExternalDatabaseDetail : EntityBase
    {
        [DataMember]
        public int Customerid { get; set; }

        [DataMember]
        public int ExternalDatabaseId { get; set; }

        [DataMember]
        public virtual ExternalDatabase ExternalDatabase { get; set; }

        [DataMember]
        public SourceSystem SourceSystem { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}
