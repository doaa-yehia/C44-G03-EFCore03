using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string CrsName { get; set; } = null!;
        [InverseProperty (nameof(StudentCourse.Course))]
        public ICollection<StudentCourse> Students { get; set; } = new HashSet<StudentCourse>();
    }
}
