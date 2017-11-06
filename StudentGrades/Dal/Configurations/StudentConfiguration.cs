namespace StudentGrades.Dal.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using StudentGrades.Models;

    public static class StudentConfiguration
    {
        public static void ConfigureStudentEntity(EntityTypeBuilder<Student> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("student");
            entityTypeBuilder.Property(s => s.Id).HasColumnName("id");
            entityTypeBuilder.Property(s => s.Name).HasColumnName("name");
            entityTypeBuilder.Property(s => s.Activo).HasColumnName("activo");
            entityTypeBuilder.HasMany(s => s.Grades).WithOne(s => s.Student);
        }
        
    }
}
