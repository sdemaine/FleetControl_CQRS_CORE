﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Northwind.Application.Commands.UpdateProduct;
using FleetControl.WebUI.FunctionalTests.Common;
using Xunit;

namespace FleetControl.WebUI.FunctionalTests.Controllers.Products
{
    public class Update : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public Update(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GivenUpdateProductCommand_ReturnsSuccessStatusCode()
        {
            var command = new UpdateNorthwindProductCommand
            {
                ProductId = 77,
                ProductName = "Original Frankfurter grüne Soße",
                SupplierId = 12,
                CategoryId = 2,
                UnitPrice = 15.00m,
                Discontinued = false
            };

            var content = Utilities.GetRequestContent(command);

            var response = await _client.PutAsync($"/api/products/update", content);

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GivenUpdateProductCommandWithInvalidId_ReturnsNotFoundStatusCode()
        {
            var invalidCommand = new UpdateNorthwindProductCommand
            {
                ProductId = 0,
                ProductName = "Original Frankfurter grüne Soße",
                SupplierId = 12,
                CategoryId = 2,
                UnitPrice = 15.00m,
                Discontinued = false
            };

            var content = Utilities.GetRequestContent(invalidCommand);

            var response = await _client.PutAsync($"/api/products/update", content);

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
