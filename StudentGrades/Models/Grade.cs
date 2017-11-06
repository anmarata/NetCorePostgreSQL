namespace StudentGrades.Models
{
    public class Grade
    {
        public int GradeNumber { get; set; }

        public string Subject { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}