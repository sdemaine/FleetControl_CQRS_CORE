using System.ComponentModel;

namespace FleetControl.Core
{
    public enum ProductUse
    {
        [Description("Fuel Only")]
        FuelOnly = 0,

        [Description("Fuel and Other")]
        FuelAndOther = 1
    }
}
