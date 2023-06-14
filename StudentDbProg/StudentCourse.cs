using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbProg
{
    internal class StudentCourse
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int CourseID { get; set; }

        public Course course { get; set; }
    }
}
