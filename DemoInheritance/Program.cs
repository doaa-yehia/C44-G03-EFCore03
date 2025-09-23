using DemoInheritance.Contexts;
using DemoInheritance.Models;

namespace DemoInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyCompanyDbContext dbContext = new MyCompanyDbContext();

            #region TPCT
            //var fullTimeEmployee = new Models.FullTimeEmployee
            //{
            //    Name = "Ahmed Ali",
            //    Aged = 30,
            //    Address = "123 Main",
            //    Salary = 60000m,
            //    StartDate = DateTime.Now
            //};

            //dbContext.FullTimeEmployees.Add(fullTimeEmployee);

            //var partTimeEmployee = new Models.PartTimeEmployee
            //{
            //    Name = "Sama Mohamed",
            //    Aged = 25,
            //    Address = "456 Elm St",
            //    HourRate = 300m,
            //    CountOfHours = 100

            //};
            //dbContext.PartTimeEmployees.Add(partTimeEmployee);
            //dbContext.SaveChanges(); 
            #endregion

            #region TPH

            //var fullTimeEmployee = new Models.FullTimeEmployee
            //{
            //    Name = "Ahmed Ali",
            //    Aged = 30,
            //    Address = "123 Main",
            //    Salary = 60000m,
            //    StartDate = DateTime.Now
            //};



            //var partTimeEmployee = new Models.PartTimeEmployee
            //{
            //    Name = "Sama Mohamed",
            //    Aged = 25,
            //    Address = "456 Elm St",
            //    HourRate = 300m,
            //    CountOfHours = 100

            //};

            //var employee = new Employee
            //{
            //    Name = "Salma",
            //    Aged = 28,
            //    Address = "Giza"
            //};

            //dbContext.Set<Employee>().Add(fullTimeEmployee);
            //dbContext.Set<Employee>().Add(partTimeEmployee);
            //dbContext.Set<Employee>().Add(employee);
            //dbContext.SaveChanges(); 



            #endregion

            #region TPT

            //var fullTimeEmployee = new Models.FullTimeEmployee
            //{
            //    Name = "Ahmed Ali",
            //    Aged = 30,
            //    Address = "123 Main",
            //    Salary = 60000m,
            //    StartDate = DateTime.Now
            //};

            //dbContext.FullTimeEmployees.Add(fullTimeEmployee);
            //dbContext.SaveChanges(); 

            //var partTimeEmployee = new Models.PartTimeEmployee
            //{
            //    Name = "Sama Mohamed",
            //    Aged = 25,
            //    Address = "456 Elm St",
            //    HourRate = 300m,
            //    CountOfHours = 100

            //};
            //dbContext.PartTimeEmployees.Add(partTimeEmployee);
            //dbContext.SaveChanges();

            //var employee = new Employee
            //{
            //    Name = "Salma",
            //    Aged = 28,
            //    Address = "Giza"
            //};
            //dbContext.Employees.Add(employee);
            //dbContext.SaveChanges();

            //var employees = dbContext.Employees;
            //if (employees is not null)
            //{
            //    foreach (var emp in employees.OfType<FullTimeEmployee>())
            //    {
            //        Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Age: {emp.Aged}, Address: {emp.Address},Salary: {emp.Salary}");

            //    }
            //}

            //var employees = dbContext.Employees;

            //if (employees is not null)
            //{
            //    foreach (var emp in employees)
            //    {
            //        Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Age: {emp.Aged}, Address: {emp.Address}");

            //    }
            //}

            #endregion
        }
    }
}
