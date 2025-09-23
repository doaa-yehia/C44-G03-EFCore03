using DemoInheritance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance.Contexts
{
    internal class MyCompanyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MyCompanyDb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //modelBuilder.Entity<Employee>()
           //             .HasDiscriminator<int>("EmployeeType")
           //             .HasValue<FullTimeEmployee>(1)
           //             .HasValue<PartTimeEmployee>(2)
           //             .HasValue<Employee>(0);

            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyCompanyDbContext).Assembly);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }

}
