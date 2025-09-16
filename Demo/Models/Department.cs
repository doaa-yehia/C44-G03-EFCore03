using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public DateTime DateOfCreation { get; set; }
        [ForeignKey(nameof(Manager))]
        public int DeptManagerId { get; set; }
        //Navigation property
        public Employee Manager { get; set; }

        public Address DeptAddress { get; set; } = null!;
    }
}
