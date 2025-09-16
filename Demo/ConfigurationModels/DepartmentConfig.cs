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
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(D => D.Manager)
                   .WithOne(E => E.ManageDepartment)
                   .HasForeignKey<Department>(D => D.DeptManagerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
