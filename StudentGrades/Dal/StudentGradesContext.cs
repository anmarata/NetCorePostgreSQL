namespace StudentGrades.Dal
{
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

        }
    }
}
