using FleetControl.Core;
using System.Runtime.Serialization;

namespace FleetControl.Domain
{
    public class VoyagerErrorCodes : EntityBase
    {
        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string ErrorDescription { get; set; }
    }
}
