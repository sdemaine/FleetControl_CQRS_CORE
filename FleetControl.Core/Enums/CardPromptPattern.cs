using System.ComponentModel.DataAnnotations;

namespace FleetControl.Core
{
    public enum CardPromptPattern
    {
        [Display(Name = "Pin Number")]
        PinNumber = 0,

        DriverId = 1,

        VehicleId = 2,

        NoPrompt = 9
    }
}
