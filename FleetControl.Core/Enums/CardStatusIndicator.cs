using System.ComponentModel;

namespace FleetControl.Core
{
    public enum CardStatusIndicator
    {
        [Description("No Action")]
        NoAction = 0,

        [Description("Cancel No Reissue")]
        CancelNoReissue = 1,

        [Description("Lost Reissue")]
        LostReissue = 2,

        [Description("Replace Same Id")]
        ReplaceSameId = 3,

        [Description("Other")]
        Other = 4
    }
}
