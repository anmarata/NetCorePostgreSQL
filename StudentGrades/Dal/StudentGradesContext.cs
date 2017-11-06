namespace StudentGrades.Dal
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using StudentGrades.Models;

    public class StudentGradesContext : DbContext
    {
        public StudentGradesContext(DbContextOptions<StudentGradesContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public void EnsureSeedData()
        {
            if (!this.Students.Any())
            {
                List<Grade> lstGrades = new List<Grade>();
                lstGrades.Add(new Grade { Subject = "Math", GradeNumber = 5 });
                lstGrades.Add(new Grade { Subject = "Chemistry", GradeNumber = 2 });
                this.Students.Add(new Student { Name = "Marco", Activo = true, Grades = lstGrades });

                lstGrades = new List<Grade>();
                lstGrades.Add(new Grade { Subject = "Math", GradeNumber = 4 });
                lstGrades.Add(new Grade { Subject = "Chemistry", GradeNumber = 4 });
                this.Students.Add(new Student { Name = "Luis", Activo = true, Grades = lstGrades });

                this.SaveChanges();
            }
        }
    }
}
