using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Demo.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public DateTime DateOfCreation { get; set; }
        [ForeignKey(nameof(Manager))]
        public int? DeptManagerId { get; set; }
        //Navigation property
        public virtual Employee Manager { get; set; }

        public virtual Address DeptAddress { get; set; } = null!;

        [InverseProperty(nameof(Employee.EmpDepatrment))]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
