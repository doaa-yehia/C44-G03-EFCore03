using Demo.DataDbContext;
using Demo.Models;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            var emp= dbContext.Set<Employee>().FirstOrDefault();
            //if (emp is not null)
            //{
            //    Console.WriteLine(emp.Name); //Doaa
            //    Console.WriteLine(emp.EmpAddress?.Country); //Null
            //}

            if (emp is not null)
            {
                Console.WriteLine(emp.Name); //Doaa
                Console.WriteLine(emp.EmpAddress?.Country); //Egypt
            }

            //var empAddress = dbContext.Set<Address>().FirstOrDefault();
            //if (emp is not null)
            //{
            //    Console.WriteLine(empAddress?.Country); //Egypt
            //}

        }
    }
}
