using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace StudentDbProg
{
    internal class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }


    }
}
