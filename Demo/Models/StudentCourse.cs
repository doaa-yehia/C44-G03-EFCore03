using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    //[PrimaryKey(nameof(StdId),nameof(CrsId))]
    internal class StudentCourse
    {
        [ForeignKey(nameof(Student))]
        public int StdId { get; set; }
        [InverseProperty(nameof(Student.Courses))]
        public virtual Student Student { get; set; } = null!;

        [ForeignKey (nameof(Course))]
        public int CrsId { get; set; }

        public virtual Course Course { get; set; } = null!;
        public int Grade {  get; set; }
    }
}
