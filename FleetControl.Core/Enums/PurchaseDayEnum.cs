using System.Runtime.Serialization;

namespace FleetControl.Core
{
    public enum PurchaseDayEnum
    {
        [EnumMember]
        NotSelected = 0,

        [EnumMember]
        All = 1,

        [EnumMember]
        MonToFri = 2,

        [EnumMember]
        Sat = 3,

        [EnumMember]
        Sun = 4,

        [EnumMember]
        MonToSat = 5,

        [EnumMember]
        MonToFriAndSun = 6,

        [EnumMember]
        SatAndSun = 7
    }
}
