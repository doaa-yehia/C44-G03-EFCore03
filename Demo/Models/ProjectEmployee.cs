using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class ProjectEmployee
    {
        public int EmpId { get; set; }
        [InverseProperty(nameof(Employee.EmpProject))]
        public Employee Employee { get; set; } = null!;

        public int proId { get; set; }
        [InverseProperty (nameof(Project.ProjectEmployees))]
        public Project Project { get; set; } = null!;
    }
}
