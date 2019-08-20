using System;
using System.Linq.Expressions;
using FleetControl.Domain;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetail_Model
    {
        public int Id { get; set; }
        

        public static Expression<Func<Customer, GetFleetCustomerDetail_Model>> Projection
        {
            get
            {
                return customer => new GetFleetCustomerDetail_Model
                {
                    Id = customer.Id
                };
            }
        }

        public static GetFleetCustomerDetail_Model Create(Customer customer)
        {
            return Projection.Compile().Invoke(customer);
        }
    }
}
