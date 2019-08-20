using AutoMapper;
using FleetControl.Application.Tests.Infrastructure;
using FleetControl.Persistence;
using Northwind.Application.Queries.GetCustomerList;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FleetControlTraders.Application.UnitTests.Infrastructure
{
    [Collection("QueryCollection")]
    public class GetNorthwindCustomersListQueryHandlerTests
    {
        private readonly NorthwindDbContext _context;
        private readonly IMapper _mapper;

        public GetNorthwindCustomersListQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetCustomersTest()
        {
            var sut = new GetNorthwindCustomersListQueryHandler(_context, _mapper);

            var result = await sut.Handle(new GetNorthwindCustomersListQuery(), CancellationToken.None);

            result.ShouldBeOfType<NorthwindCustomersListViewModel>();

            result.Customers.Count.ShouldBe(3);
        }
    }
}