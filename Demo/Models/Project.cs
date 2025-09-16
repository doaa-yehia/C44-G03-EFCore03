using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [InverseProperty(nameof(ProjectEmployee.Project))]
        public ICollection<ProjectEmployee> ProjectEmployees { get; set; }=new HashSet<ProjectEmployee>();
    }
}
