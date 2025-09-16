using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Employee
    {
        public int EmpId { get; set; }

        [MinLength(3, ErrorMessage = "Name Must Be At Least 3 char")]
        public string? Name { get; set; }

        public decimal Sallary { get; set; }

        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        public string? password { get; set; }

        public string userName { get => Email.Split('@')[0]; }

        //Navigation Property Manage RelationShip
        public Department? ManageDepartment { get; set; }

        //Navigation Property Address RelationShip
        public Address EmpAddress { get; set; } = null!;

    }
}
