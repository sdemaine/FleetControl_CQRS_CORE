﻿using Microsoft.EntityFrameworkCore;
using Northwind.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Interfaces
{
    public interface INorthwindDbContext
    {
        DbSet<Category> Categories { get; set; }

        //DbSet<Customer> Customers { get; set; }

        DbSet<Employee> Employees { get; set; }

        DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

        DbSet<OrderDetail> OrderDetails { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<Product> Products { get; set; }

        DbSet<Region> Region { get; set; }

        DbSet<Shipper> Shippers { get; set; }

        DbSet<Supplier> Suppliers { get; set; }

        DbSet<Territory> Territories { get; set; }

        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
