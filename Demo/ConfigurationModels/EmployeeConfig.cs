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
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            #region mapping
            builder.ToTable("Employee02");
            builder.HasKey(E => E.EmpId);
            builder.Property(E => E.EmpId)
                   .UseIdentityColumn(10, 10);

            builder.Property(E => E.Name)
                   .HasColumnName("EmployeeName")
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(E => E.Sallary)
                   .HasPrecision(10, 2);

            builder.ToTable(E => E.HasCheckConstraint(
                            "Check_Age_Range", "[Age] between 22 and 40"));

            builder.ToTable(E => E.HasCheckConstraint(
                            "Check_Allowed_Ages", "[Age] in (24,29,28)"));

            builder.ToTable(E => E.HasCheckConstraint(
                           "Check_Age_Range", "[Age] Not in (30,35,25)"));

            builder.Property(E => E.Email)
                   .IsRequired()
                   .HasDefaultValue("hh@mm.com")
                   .HasAnnotation("DataType", "EmailAddress");

            builder.ToTable(T => T.HasCheckConstraint(
                   "Check_Employee_Email", "[Email] like '%@%.%'"));

            builder.Property(E => E.password)
                   .HasAnnotation("DataType", "Password");

            builder.Ignore(E => E.userName);
            #endregion

            #region RelationShips
            //Address RelatioShip

            //builder.HasOne(E => E.EmpAddress)
            //       .WithOne(A => A.Employee)
            //       .HasForeignKey<Address>(A => A.EmpId);

            ///owend Relationship
            builder.OwnsOne(E => E.EmpAddress, OA =>
            {
                OA.Property(A => A.City)
                  .HasColumnName("EmpCity")
                  .HasColumnType("varchar(20)")
                  .IsRequired();
            });

            builder.HasOne(E => E.EmpDepatrment)
                   .WithMany()
                   .HasForeignKey(E => E.DeptId)
                   //.IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            #endregion
        }
    }
}
