using System.Runtime.Serialization;

namespace FleetControl.Core
{
    [DataContract]
    public enum EmbossingElement
    {
        [EnumMember]
        NotSelected = 0,

        [EnumMember]
        VehicleLicense = 1,

        [EnumMember]
        VehicleDescription = 2,

        [EnumMember]
        VinNumber = 3,

        [EnumMember]
        DriverName = 4,

        [EnumMember]
        DepartmentName = 5,

        [EnumMember]
        DepartmentNumberAndName = 6
    }
}
