using FleetControl.Application.Tests.Infrastructure;
using FleetControl.Persistence;
using Northwind.Application.Queries.GetCustomerDetail;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Northwind.Application.Tests.Customers.Queries
{
    [Collection("QueryCollection")]
    public class GetNorthwindCustomerDetailQueryHandlerTests
    { 
        private readonly NorthwindDbContext _context;

        public GetNorthwindCustomerDetailQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
        }    

        public async Task GetCustomerDetail()
        {
            var sut = new GetNorthwindCustomerDetailQueryHandler(_context);

            var result = await sut.Handle(new GetNorthwindCustomerDetailQuery { Id = "JASON" }, CancellationToken.None);

            result.ShouldBeOfType<NorthwindCustomerDetailModel>();
            result.Id.ShouldBe("JASON");
        }
    }
}
