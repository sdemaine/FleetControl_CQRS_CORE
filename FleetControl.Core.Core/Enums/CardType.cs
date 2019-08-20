using System.ComponentModel;

namespace FleetControl.Core
{
    public enum CardType
    {
        [Description("Voyager Card")]
        VoyagerCard = 1,
        Keyfob = 2,
        VDM = 3,
        Keypad = 4,
        [Description("Keyfob Type-K")]
        KeyfobTypeK = 5,
        None = 6
    }
}
