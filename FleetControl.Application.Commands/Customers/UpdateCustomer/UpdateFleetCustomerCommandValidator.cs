using FluentValidation;
using System.Collections.Generic;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateFleetCustomer_Command>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(x => x.Customer.CustomerName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Customer.BillingCode).Custom((billingCode, context) => {


                if (!IsValidBillingCode(billingCode))
                {
                    context.AddFailure("The billing code is not valid");
                }
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
    }
}
