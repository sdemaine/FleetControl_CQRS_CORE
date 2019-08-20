using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Northwind.Application.Queries.GetCustomerDetail;
using FleetControl.WebUI.FunctionalTests.Common;
using Xunit;

namespace FleetControl.WebUI.FunctionalTests.Controllers.Customers
{
    public class GetById : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public GetById(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GivenId_ReturnsCustomerViewModel()
        {
            var id = "ALFKI";

            var response = await _client.GetAsync($"/api/customers/get/{id}");

            response.EnsureSuccessStatusCode();

            var customer = await Utilities.GetResponseContent<NorthwindCustomerDetailModel>(response);

            Assert.Equal(id, customer.Id);
        }

        [Fact]
        public async Task GivenInvalidId_ReturnsNotFoundStatusCode()
        {
            var invalidId = "AAAAA";

            var response = await _client.GetAsync($"/api/customers/get/{invalidId}");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
