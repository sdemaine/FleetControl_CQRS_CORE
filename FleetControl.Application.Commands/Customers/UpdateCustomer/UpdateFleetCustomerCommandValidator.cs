using FluentValidation;
using FluentValidation.Validators;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateFleetCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(x => x.Customer.CustomerName).MaximumLength(50).NotEmpty();


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
    }
}
