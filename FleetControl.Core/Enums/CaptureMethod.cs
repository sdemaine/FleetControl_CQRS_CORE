namespace FleetControl.Core
{
    public enum CaptureMethod
    {
        ElectronicSwiped = 1,
        ElectronicKeyed = 2,
        ElectronicSwipedOffline = 4,
        ElectronicKeyedOffline = 5,
        CardActivatedReader = 8,
        Paper = 9
    }
}
