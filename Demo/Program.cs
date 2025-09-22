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

            //bool dataSeeded= CompanyDbContextSeeding.DataSeeding(dbContext);
            // if(dataSeeded)
            // {
            //     Console.WriteLine("Seeded");
            // }
            // else
            // {
            //     Console.WriteLine("Not Seeded");
            // }
            #endregion

            #endregion

            #region Eager Loading

            #region Ex01
            //var emp01 = dbContext.Set<Employee>()
            //                .FirstOrDefault(E => E.EmpId == 20);
            //if (emp01 is not null)
            //{
            //    Console.WriteLine(emp01.Name);                //Doaa
            //    Console.WriteLine($"Employee department= " +  //null
            //        $"{emp01.EmpDepatrment?.DeptName}");
            //}

            //var emp02 = dbContext.Set<Employee>()
            //                .Include(E => E.EmpDepatrment)
            //                .FirstOrDefault(E => E.EmpId == 20);
            //if (emp02 is not null)
            //{
            //    Console.WriteLine(emp02.Name);                //Doaa
            //    Console.WriteLine($"Employee department= " +  //Hr
            //        $"{emp02.EmpDepatrment?.DeptName}");
            //}

            #endregion

            #region Ex02

            //var student = dbContext.Set<Student>()
            //                    .Include(S => S.Courses)
            //                    .FirstOrDefault(S => S.Id == 1);
            //if (student is not null)
            //{
            //    Console.WriteLine($"CR ID = {student.Courses?.CrsName}");//null
            //}

            //var student2 = dbContext.Set<Student>()
            //                    .Include(S => S.Courses)
            //                    .ThenInclude(SC => SC.Course)
            //                    .FirstOrDefault(S => S.Id == 1);
            //if (student2 is not null)
            //{
            //        Console.WriteLine($"CR ID = {student2.Courses?.CrsName}");

            //}
            #endregion

            #endregion

            #region Explicit loading

            #region EX01

            //var emp03 = dbContext.Set<Employee>()
            //                .FirstOrDefault(E => E.EmpId == 20);
            //if (emp03 is not null)
            //{
            //    Console.WriteLine(emp03.Name);
            //    dbContext.Entry(emp03)
            //             .Reference(E => E.EmpDepatrment)
            //             .Load();
            //    Console.WriteLine($"Employee department= {emp03.EmpDepatrment.DeptName}");
            //}

            #endregion

            #region Ex02
            //var dept = dbContext.Set<Department>()
            //              .FirstOrDefault(D => D.Id == 1);
            //if (dept is not null)
            //{
            //    Console.WriteLine(dept.DeptName);
            //    dbContext.Entry(dept)
            //             .Collection(D => D.Employees)
            //             .Query().Where(E=>E.Age>25)
            //             .Load();
            //    Console.WriteLine($"Employee department= {dept.Employees}");
            //    foreach (var emp in dept.Employees)
            //    {
            //        Console.WriteLine($"Employee Name= {emp.Name}");
            //    }
            //}


            #endregion

            #endregion

            #region Lazy loading

            #region Ex01

            //var emp03 = dbContext.Set<Employee>()
            //                .FirstOrDefault(E => E.EmpId == 20);
            //if (emp03 is not null)
            //{
            //    Console.WriteLine(emp03.Name);

            //    Console.WriteLine($"Employee department= {emp03.EmpDepatrment.DeptName}");
            //}
            #endregion

            #region Ex02

            //var dept = dbContext.Set<Department>()
            //              .FirstOrDefault(D => D.Id == 1);
            //if (dept is not null)
            //{
            //    Console.WriteLine(dept.DeptName);

            //    Console.WriteLine($"Employee department= {dept.Employees}");
            //    foreach (var emp in dept.Employees)
            //    {
            //        Console.WriteLine($"Employee Name= {emp.Name}");
            //    }
            //}

            #endregion

            #endregion

            #region Join Operator

            #region Join()

            #region EX01
            //var deptName = dbContext.Set<Department>()
            //            .Join(dbContext.Set<Employee>(),
            //                  D => D.Id,
            //                  E => E.DeptId,
            //                  (D, E) => new
            //                  {
            //                      DeptName = D.DeptName,
            //                      EmpName = E.Name
            //                  }
            //            );
            //deptName = from D in dbContext.Set<Department>()
            //           join E in dbContext.Set<Employee>()
            //           on D.Id equals E.DeptId
            //           select new
            //           {
            //               DeptName = D.DeptName,
            //               EmpName = E.Name
            //           };
            //foreach (var item in deptName) Console.WriteLine(item); 
            #endregion

            #region EX02

            //var DeptWithManager= dbContext.Set<Department>()
            //                              .Join(dbContext.Set<Employee>(),
            //                                    D => D.DeptManagerId,
            //                                    E => E.EmpId,
            //                                    (D, E) => new
            //                                    {
            //                                        DeptName = D.DeptName,
            //                                        ManagerName = E.Name
            //                                    }
            //                              );
            //DeptWithManager = from D in dbContext.Set<Department>()
            //                  join E in dbContext.Set<Employee>()
            //                  on D.DeptManagerId equals E.EmpId
            //                  select new
            //                  {
            //                      DeptName = D.DeptName,
            //                      ManagerName = E.Name
            //                  };
            //foreach (var item in DeptWithManager) Console.WriteLine(item);

            #endregion

            #endregion

            #endregion

            #region Group Join

            #region Ex01

            //var Result = dbContext.Set<Department>()
            //                    .GroupJoin(dbContext.Set<Employee>(),
            //                               D => D.Id,
            //                               E => E.DeptId,
            //                               (D, Employees) => new
            //                               {
            //                                   DeptName = D.DeptName,
            //                                   Employees = Employees
            //                               }
            //                    );
            //Result = from D in dbContext.Set<Department>()
            //         join E in dbContext.Set<Employee>()
            //         on D.Id equals E.DeptId into EmployeesGroup
            //         select new
            //         {
            //             DeptName = D.DeptName,
            //             Employees = EmployeesGroup
            //         };

            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Department Name = {group.DeptName}");
            //    foreach (var emp in group.Employees)
            //    {
            //        Console.WriteLine($"\tEmployee Name = {emp.Name}");
            //    }
            //    Console.WriteLine("===================================");
            //}

            #endregion

            #region EX02

            //var Result = dbContext.Set<Department>()
            //                    .GroupJoin(dbContext.Set<Employee>(),
            //                               D => D.Id,
            //                               E => E.DeptId,
            //                               (D, Employees) => new
            //                               {
            //                                   DeptName = D.DeptName,
            //                                   Employees = Employees
            //                               }
            //                    ).Where(E=>E.Employees.Count()>2);

            //Result= from D in dbContext.Set<Department>()
            //         join E in dbContext.Set<Employee>()
            //         on D.Id equals E.DeptId into EmployeesGroup
            //         where EmployeesGroup.Count() > 2
            //         select new
            //         {
            //             DeptName = D.DeptName,
            //             Employees = EmployeesGroup
            //         };

            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Department Name = {group.DeptName}");
            //    foreach (var emp in group.Employees)
            //    {
            //        Console.WriteLine($"\tEmployee Name = {emp.Name}");
            //    }
            //    Console.WriteLine("===================================");
            //}

            #endregion



            #endregion

            #region Group Category Join()

            #region EX01
            //var DeptWithEmp = dbContext.Set<Department>()
            //                           .GroupJoin(dbContext.Set<Employee>(),
            //                                 D => D.Id,
            //                                 E => E.DeptId,
            //                                 (D, Employees) => new
            //                                 {
            //                                     Department = D.Id,
            //                                     Employees
            //                                 } 
            //                           ).SelectMany(X=>X.Employees);

            var vDeptWithEmp = from D in dbContext.Set<Department>()
                          join E in dbContext.Set<Employee>()
                          on D.Id equals E.DeptId into Employees
                          select new
                          {
                              Employees = Employees,
                              D
                          } into groups 
                          select groups.Employees;


            //DeptWithEmp = from D in dbContext.Set<Department>()
            //              join E in dbContext.Set<Employee>()
            //                on D.DeptManagerId equals E.DeptId
            //                select new
            //                {
            //                    DeptName = D.DeptName,
            //                    EmpName = E.Name
            //                };

            //foreach (var item in DeptWithEmp) Console.WriteLine(item);

            #endregion

            #region Left outer Join 

            #region EX03
            //var result = dbContext.Set<Department>()
            //             .GroupJoin(dbContext.Set<Employee>(),
            //                        D => D.Id,
            //                        E => E.EmpId,
            //                        (D, Employees) => new
            //                        {
            //                            Dept= D,
            //                            Employees
            //                        }
            //             ).SelectMany(X => X.Employees.DefaultIfEmpty(), (D, emp) => new
            //             {
            //                 Dept = D.Dept.Id,
            //                 EmpId = emp != null ? emp.EmpId : 0,
            //                 EmpName = emp != null ? emp.Name : "No Employee"
            //             });

            // result = from D in dbContext.Set<Department>()
            //              join E in dbContext.Set<Employee>()
            //              on D.Id equals E.EmpId into Employees
            //              select new
            //              {
            //                  Department = D,
            //                  Employees
            //              } into groups
            //              from E in groups.Employees.DefaultIfEmpty()
            //              select new 
            //              {
            //                  Department= groups.Department.Id,
            //                  EmpId = E != null ? E.EmpId : 0,
            //                  EmpName = E != null ? E.Name : "No Employee"
            //              }; 
            #endregion

            #region EX04

            //var result = dbContext.Set<Employee>()
            //             .GroupJoin(dbContext.Set<Department>(),
            //                        E => E.DeptId,
            //                        D => D.Id,
            //                        (E, Departments) => new
            //                        {
            //                            Employees=E,
            //                            Departments
            //                        }
            //             ).SelectMany(X => X.Departments.DefaultIfEmpty(), (R, D) => new
            //             {
            //                 EmpId = R.Employees.EmpId,
            //                 EmpName= R.Employees.Name,
            //                 DeptId = D != null ? D.Id : 0,
            //                 DeptName = D != null ? D.DeptName : "No Employee"
            //             });
            //result=from E in dbContext.Set<Employee>()
            //        join D in dbContext.Set<Department>()
            //        on E.DeptId equals D.Id into Departments
            //        select new
            //        {
            //            Employees = E,
            //            Departments
            //        } into groups
            //        from D in groups.Departments.DefaultIfEmpty()
            //        select new
            //        {
            //            EmpId = groups.Employees.EmpId,
            //            EmpName = groups.Employees.Name,
            //            DeptId = D != null ? D.Id : 0,
            //            DeptName = D != null ? D.DeptName : "No Department"
            //        };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Cross Join

            //var res= dbContext.Set<Employee>()
            //             .SelectMany(E => dbContext.Set<Department>()
            //                         .Select(D => new
            //                         {
            //                             DeptName = D.DeptName,
            //                             EmpName = E.Name
            //                         }
            //             ));
            //res=from E in dbContext.Set<Employee>()
            //     from D in dbContext.Set<Department>()
            //     select new
            //     {
            //         DeptName = D.DeptName,
            //         EmpName = E.Name
            //     };
            //foreach (var item in res) Console.WriteLine(item);

            #endregion


                #endregion

        }
    }
}
