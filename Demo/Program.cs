using Demo.DataDbContext;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            //var emp= dbContext.Set<Employee>().FirstOrDefault();
            //if (emp is not null)
            //{
            //    Console.WriteLine(emp.Name); //Doaa
            //    Console.WriteLine(emp.EmpAddress?.Country); //Null
            //}

            //if (emp is not null)
            //{
            //    Console.WriteLine(emp.Name); //Doaa
            //    Console.WriteLine(emp.EmpAddress?.Country); //Egypt
            //}

            //var empAddress = dbContext.Set<Address>().FirstOrDefault();
            //if (emp is not null)
            //{
            //    Console.WriteLine(empAddress?.Country); //Egypt
            //}


            #region Many To Many
            //dbContext.Students.Add(new Student {
            //    StdName="Doaa",
            //});
            //dbContext.Courses.AddRange(new Course { CrsName="OOP" },
            //                           new Course { CrsName="C#"},
            //                           new Course { CrsName="EF Core"});
            //dbContext.SaveChanges();


            //var std01 = dbContext.Students.FirstOrDefault();

            //var crs01= dbContext.Courses.FirstOrDefault(C=>C.Id==1);
            //var crs02= dbContext.Courses.FirstOrDefault(C=>C.Id==3);

            //if (std01 is not null && crs01 is not null )
            //{
            //    std01.Courses.Add(new StudentCourse()
            //    {
            //        Course = crs01,
            //        Student=std01,
            //        Grade=90
            //    });
            //}

            //if (std01 is not null && crs02 is not null )
            //{
            //    std01.Courses.Add(new StudentCourse()
            //    {
            //        Course = crs02,
            //        Student=std01,
            //        Grade=80
            //    });
            //}
            //dbContext.SaveChanges();

            //Console.WriteLine(std01?.StdName); 
            #endregion

            #region Data Seeding

            #region Manualy

            //List<Project> projects = new List<Project>
            //   {
            //       new Project{Name="P01"},
            //       new Project{Name="P02"},
            //       new Project{Name="P03"},
            //       new Project{Name="P04"},
            //       new Project{Name="P05"}
            //   };

            //if (!dbContext.Set<Project>().Any())
            //{
            //    dbContext.Set<Project>().AddRange(projects);
            //    dbContext.SaveChanges();
            //}

            #endregion

            #region Dinamically

           bool dataSeeded= CompanyDbContextSeeding.DataSeeding(dbContext);
            if(dataSeeded)
            {
                Console.WriteLine("Seeded");
            }
            else
            {
                Console.WriteLine("Not Seeded");
            }
            #endregion

            #endregion

        }
    }
}
