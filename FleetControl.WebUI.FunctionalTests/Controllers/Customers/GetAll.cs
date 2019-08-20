using System.Net.Http;
using System.Threading.Tasks;
using FleetControl.Application.Queries.GetCustomerList;
using FleetControl.WebUI.FunctionalTests.Common;
using Northwind.Application.Queries.GetCustomerList;
using Xunit;

namespace FleetControl.WebUI.FunctionalTests.Controllers.Customers
{
    public class GetAll : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public GetAll(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsCustomersListViewModel()
        {
            var response = await _client.GetAsync("/api/customers/getall");

            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<NorthwindCustomersListViewModel>(response);

            Assert.IsType<NorthwindCustomersListViewModel>(vm);
            Assert.NotEmpty(vm.Customers);
        }
    }
}
