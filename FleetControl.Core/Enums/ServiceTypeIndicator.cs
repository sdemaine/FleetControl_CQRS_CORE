using System.ComponentModel;

namespace FleetControl.Core
{
    public enum ServiceTypeIndicator
    {
        [Description("Self Service")]
        SelfService = 0,

        [Description("Full Service")]
        FullService = 1,

        [Description("Other")]
        Other = 2,

        [Description("Unknown")]
        Unknown = 9
    }
}
