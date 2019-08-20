﻿using System.Net.Http;
using System.Threading.Tasks;
using Northwind.Application.Commands.CreateProduct;
using FleetControl.WebUI.FunctionalTests.Common;
using Xunit;

namespace FleetControl.WebUI.FunctionalTests.Controllers.Products
{
    public class Create : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public Create(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GivenCreateProductCommand_ReturnsNewProductId()
        {
            var command = new CreateNorthwindProductCommand
            {
                ProductName = "Coffee",
                SupplierId = 1,
                CategoryId = 1,
                UnitPrice = 19.00m,
                Discontinued = false
            };

            var content = Utilities.GetRequestContent(command);

            var response = await _client.PostAsync($"/api/products/create", content);

            response.EnsureSuccessStatusCode();

            var productId = await Utilities.GetResponseContent<int>(response);

            Assert.NotEqual(0, productId);
        }
    }
}
