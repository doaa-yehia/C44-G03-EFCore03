using Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ConfigurationModels
{
    internal class EmployeeCarConfig : IEntityTypeConfiguration<EmployeeCar>
    {
        public void Configure(EntityTypeBuilder<EmployeeCar> builder)
        {
            builder.HasOne(EC => EC.Employee)
                   .WithOne()
                   .HasForeignKey<EmployeeCar>(EC => EC.EmployeeId);
            builder.HasOne(EC => EC.Car)
                   .WithOne()
                   .HasForeignKey<EmployeeCar>(EC => EC.CarId);
            builder.HasKey(EC => EC.EmployeeId);
        }
    }
}
