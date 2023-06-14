using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbProg
{
    internal class Course
    {
        public int CourseId { get; set; }
        public String CourseName { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
