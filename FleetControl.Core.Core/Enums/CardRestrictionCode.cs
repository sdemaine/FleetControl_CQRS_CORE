namespace FleetControl.Core
{
    public enum CardRestrictionCode
    {
        NoIdNumberOrOdometerFuelAndOther = 1,
        NoIdNumberOrOdometerFuelOnly = 2,
        IdNumberOnlyFuelAndOther = 3,
        IdNumberOnlyFuelOnly = 4,
        OdometerOnlyFuelAndOther = 5,
        OdometerOnlyFuelOnly = 6,
        IdNumberAndOdometerFuelAndOther = 7,
        IdNumberAndOdometerFuelOnly = 8
    }
}
