using System.ComponentModel;

namespace FleetControl.Core
{
    public enum HardSoftExceptionModes
    {
        [Description("Not Used")]
        NotUsed = -1,

        [Description("Soft Limit")]
        SoftLimit = 0,
        
        [Description("Hard Limit")]
        HardLimit = 1,
        
        [Description("Exception Reporting")]
        ExceptionReporting = 2
    }
}
