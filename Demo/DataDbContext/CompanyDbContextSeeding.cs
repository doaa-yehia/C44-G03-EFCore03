using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.DataDbContext
{
    internal static class CompanyDbContextSeeding
    {
        public static bool DataSeeding(CompanyDbContext dbContext)
        {
            try
            {
                if (dbContext.Set<Employee>().Any()) return false;
                var EmployeeData = File.ReadAllText("employees.json");
                if (string.IsNullOrWhiteSpace(EmployeeData)) return false;
                var Employees=JsonSerializer.Deserialize<List<Employee>>(EmployeeData,
                                            new JsonSerializerOptions { PropertyNameCaseInsensitive=true});
                if(Employees is null || Employees.Count == 0) return false;
                dbContext.Set<Employee>().AddRange(Employees);
                if (dbContext.SaveChanges() == 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
