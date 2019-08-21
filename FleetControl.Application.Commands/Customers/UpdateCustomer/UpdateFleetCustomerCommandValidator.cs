using FluentValidation;
using System.Collections.Generic;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateFleetCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(x => x.Customer.CustomerName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Customer.BillingCode).Custom((billingCode, context) => {


                if (!IsValidBillingCode(billingCode))
                {
                    context.AddFailure("The billing code is not valid");
                }

                
                //if (list.Count > 10)
                //{
                //    context.AddFailure("The list must contain 10 items or fewer");
                //}
            });


            //RuleFor(c => c.PostalCode).Matches(@"^\d{4}$")
            //    .When(c => c.Country == "Australia")
            //    .WithMessage("Australian Postcodes have 4 digits");

            //RuleFor(c => c.Phone)
            //    .Must(HaveQueenslandLandLine)
            //    .When(c => c.Country == "Australia" && c.PostalCode.StartsWith("4"))
            //    .WithMessage("Customers in QLD require at least one QLD landline.");
        }

        //private static bool HaveQueenslandLandLine(UpdateFleetCustomerCommand model, string phoneValue, PropertyValidatorContext ctx)
        //{
        //    return model.Phone.StartsWith("07") || model.Fax.StartsWith("07");
        //}

        public enum Group
        {
            A,
            B,
            C
        }

        public static List<string> BillingCodes = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "M", "N", "P", "Q", "S", "T", "W" };


        bool IsValidBillingCode(string billingCode)
        {
            if (billingCode == null || billingCode == string.Empty) return false;

            if (BillingCodes.Contains(billingCode.ToUpper()))
            {
                return true;
            }

            return false;
        }

        //public static class BillingCode
        //{
        //    public const string AIRBORNE_TWICE_A_MONTH = "A";
        //    public const string TWICE_A_MONTH = "B";
        //    public const string COMMERCIAL_WEEKLY_BILLING = "C";
        //    public const string WEEKLY_WET_HOSING = "E";
        //    public const string WET_HOSING = "D";
        //    public const string BI_MONTHLY_WET_HOSING = "F";
        //    public const string MONTHLY_WET_HOSING = "G";
        //    public const string HOUSING_AUTHORITY = "H";
        //    public const string IGNORE = "I";
        //    public const string MONTHLY = "M";
        //    public const string NONE = "N";
        //    public const string POST_OFFICE = "P";
        //    public const string CONTINENTAL_CHELSEA = "Q";
        //    public const string SWITCH_CYCLES = "S";
        //    public const string END_OF_MONTH_TOTAL_ACTIVITY = "T";
        //    public const string WEEKLY_NYC_BILLING = "W";

        bool IsValidResourceGroup(string group)
        {
            //foreach (var c in Enum.GetValues(typeof(BillingCode)))
            //{
            //    if (string.Equals(group.Trim(), $"{c}", StringComparison.CurrentCultureIgnoreCase))
            //    {
            //        return true;
            //    }
            //}
            //return false;

            return false;
        }
    }
}
