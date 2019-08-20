using System.ComponentModel;

namespace FleetControl.Core
{
    public enum EmbossingOnCard
    {
        //[Description("No Embossing")]
        //NoEmbossing = 0,

        //[Description("Vehicle License")]
        //VehicleLicense = 1,

        //[Description("Vehicle Description")]
        //VehicleDescription = 2,

        //[Description("VIN Number")]
        //VinNumber = 3,

        //[Description("Driver Name")]
        //DriverName = 4,

        //[Description("Vehicle License or Driver Name")]
        //VehicleLicenseOrDriverName = 5,

        [Description("Vehicle Description or Driver Name")]
        VehicleDescriptionOrDriverName = 6

        //[Description("Vin Number or Driver Name")]
        //VinNumberOrDriverName = 7
    }
}
