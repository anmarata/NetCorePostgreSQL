﻿namespace StudentGrades.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public string GradeNumber { get; set; }

        public string Subject { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}