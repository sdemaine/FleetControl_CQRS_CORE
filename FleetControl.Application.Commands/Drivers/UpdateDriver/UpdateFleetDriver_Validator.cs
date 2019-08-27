using FluentValidation;
using System.Collections.Generic;

namespace FleetControl.Application.Commands.UpdateCustomer
{
    public class UpdateFleetDriver_Validator : AbstractValidator<UpdateFleetDriver_Command>
    {
        public UpdateFleetDriver_Validator()
        {
            RuleFor(x => x.Driver.FirstName).MaximumLength(50).NotEmpty();
            //RuleFor(x => x.Driver.LastName).Custom((billingCode, context) => {


                //if (!IsValidBillingCode(billingCode))
                //{
                //    context.AddFailure("The billing code is not valid");
                //}
            //});
        }
    }
}
