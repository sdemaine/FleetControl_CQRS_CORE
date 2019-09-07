
namespace FleetControl.WebUI.Helpers
{
    public static class Constants
    {
        public static class Strings
        {
            public static class JwtClaimIdentifiers
            {
                public const string Rol = "rol", Id = "id";
            }

            public static class JwtClaims
            {
                public const string ApiAccess = "api_access";
                public const string CustomerEdit = "customer_edti";
                public const string CardEdit= "card_edit";
                public const string VehicleEdit = "vehicle_edit";
                public const string DriverEdit = "driver_edit";

                public const string CardGrid = "card_dx_grid";
                public const string VehicleGrid = "vehicle_dx_grid";
                public const string DriverGrid = "driver_dx_grid";
            }
        }
    }
}
