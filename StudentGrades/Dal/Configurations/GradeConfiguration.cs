namespace StudentGrades.Dal.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using StudentGrades.Models;

    public class GradeConfiguration
    {
        public static void ConfigureGradeEntity(EntityTypeBuilder<Grade> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("grade");
            entityTypeBuilder.Property(s => s.GradeNumber).HasColumnName("gradenumber");
            entityTypeBuilder.Property(s => s.Subject).HasColumnName("subject");
            entityTypeBuilder.Property(s => s.StudentId).HasColumnName("studentid");
            entityTypeBuilder.HasKey(g => new { g.StudentId, g.Subject });
        }


    }
}
