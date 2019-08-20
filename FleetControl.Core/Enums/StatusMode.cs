using System.ComponentModel;

namespace FleetControl.Core
{
    public enum StatusMode : int
    {
        [Description("Active")]
        Active = 1,

        [Description("Hold")]
        Hold = 2,

        [Description("Terminated")]
        Terminated = 3,

        [Description("Pending")]
        Pending = 4
    }
}
