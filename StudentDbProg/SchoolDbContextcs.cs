using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace StudentDbProg
{
    internal class SchoolDbContextcs : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseSqlServer(@"Server=SELENA\SQLEXPRESS;Database=SchoolDb;Integrated Security=true");



        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentID ,sc.CourseID});

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc=>sc.Student)
                .WithMany(s=>s.StudentCourses)
                .HasForeignKey(cs=>cs.StudentID);


            modelBuilder.Entity<StudentCourse>()
               .HasOne(sc => sc.course)
               .WithMany(s => s.StudentCourses)
               .HasForeignKey(cs => cs.CourseID);

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseName = "Mathematics" },
                new Course { CourseId = 2, CourseName = "Database" });

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID = 1, StudentName = "Subhan" },
                new Student { StudentID = 2, StudentName = "Selena" });

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentID = 1, CourseID=1 },
                new StudentCourse { StudentID = 2, CourseID=2},
                new StudentCourse { StudentID = 1, CourseID = 2 });




        }
    }
}
