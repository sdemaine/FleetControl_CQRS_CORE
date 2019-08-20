using System.ComponentModel;

namespace FleetControl.Core
{
    public enum HardSoftModes
    {
        [Description("Not Used")]
        NotUsed = -1,

        [Description("Soft Limit")]
        SoftLimit = 0,

        [Description("Hard Limit")]
        HardLimit = 1
    }
}
