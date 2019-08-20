using FleetControl.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    [Table("InterfaceDatasource")]
    public class InterfaceDatasource : EntityBase
    {
        [DataMember]
        public string Name { get; set; }
    }
}
