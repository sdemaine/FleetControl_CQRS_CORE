﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Northwind.Application.Queries.Models;
using FleetControl.WebUI.FunctionalTests.Common;
using Xunit;

namespace FleetControl.WebUI.FunctionalTests.Controllers.Categories
{
    public class GetCategoryPreview : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public GetCategoryPreview(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsIEnumerableOfCategoryPreviewDto()
        {
            var response = await _client.GetAsync("/api/categories/getcategorypreview");

            response.EnsureSuccessStatusCode();

            var categories = await Utilities.GetResponseContent<IEnumerable<CategoryPreviewDto>>(response);

            Assert.NotEmpty(categories);
        }
    }
}
