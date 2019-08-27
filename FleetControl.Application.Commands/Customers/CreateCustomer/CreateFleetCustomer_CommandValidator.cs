using FluentValidation;
using System.Collections.Generic;

namespace FleetControl.Application.Commands.Customers.CreateCustomer
{
    public class CreateFleetCustomer_CommandValidator : AbstractValidator<CreateFleetCustomer_Command>
    {
        public CreateFleetCustomer_CommandValidator()
        {
            RuleFor(x => x.Customer.CustomerName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Customer.LiftingNumber).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();
            RuleFor(x => x.Customer.LockCode).NotEmpty();












            RuleFor(x => x.Customer.BillingCode).Custom((billingCode, context) => {


                if (!IsValidBillingCode(billingCode))
                {
                    context.AddFailure("The billing code is not valid");
                }
            });
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
