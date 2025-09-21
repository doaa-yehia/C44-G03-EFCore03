using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string StdName { get; set; } = null!;
        [InverseProperty (nameof( StudentCourse.Student))]
        public virtual ICollection<StudentCourse> Courses { get; set; }=new HashSet<StudentCourse>();
    }
}
