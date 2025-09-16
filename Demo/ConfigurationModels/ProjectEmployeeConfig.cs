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
    internal class ProjectEmployeeConfig : IEntityTypeConfiguration<ProjectEmployee>
    {
        public void Configure(EntityTypeBuilder<ProjectEmployee> builder)
        {
            builder.HasKey(PE => PE.EmpId);

            builder.HasOne(EP => EP.Employee)
                   .WithOne(E => E.EmpProject)
                   .HasForeignKey<ProjectEmployee>(PE => PE.EmpId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(PE=>PE.Project)
                   .WithMany(P=>P.ProjectEmployees)
                   .HasForeignKey(PE=>PE.proId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
