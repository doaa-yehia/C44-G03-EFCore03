using DemoInheritance.Contexts;

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




        }
    }
}
