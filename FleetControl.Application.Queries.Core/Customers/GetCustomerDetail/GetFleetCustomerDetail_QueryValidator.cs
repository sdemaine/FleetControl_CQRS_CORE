using FluentValidation;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetailQueryValidator : AbstractValidator<GetFleetCustomerDetail_Query>
    {
        public GetFleetCustomerDetailQueryValidator()
        {
            RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
