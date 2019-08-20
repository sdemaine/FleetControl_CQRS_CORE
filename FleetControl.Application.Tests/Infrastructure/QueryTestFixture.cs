using System;
using AutoMapper;
using FleetControl.Persistence;
using Northwind.Application.Tests.Infrastructure;
using Xunit;

namespace FleetControl.Application.Tests.Infrastructure
{
    public class QueryTestFixture : IDisposable
    {
        public NorthwindDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public QueryTestFixture()
        {
            Context = NorthwindContextFactory.Create();
            Mapper = AutoMapperFactory.Create();
        }

        public void Dispose()
        {
            NorthwindContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}