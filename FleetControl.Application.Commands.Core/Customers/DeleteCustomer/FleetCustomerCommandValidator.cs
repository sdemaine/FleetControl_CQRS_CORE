using FluentValidation;

namespace FleetControl.Application.Commands.DeleteCustomer
{
    public class DeleteFleetCustomerCommandValidator : AbstractValidator<DeleteFleetCustomerCommand>
    {
        public DeleteFleetCustomerCommandValidator()
        {
            //RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
