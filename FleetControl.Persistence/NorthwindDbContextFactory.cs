using Microsoft.EntityFrameworkCore;
using FleetControl.Persistence.Infrastructure;

namespace FleetControl.Persistence
{
    public class NorthwindDbContextFactory : DesignTimeDbContextFactoryBase<FleetControlDbContext>
    {
        protected override FleetControlDbContext CreateNewInstance(DbContextOptions<FleetControlDbContext> options)
        {
            return new FleetControlDbContext(options);
        }
    }
}
