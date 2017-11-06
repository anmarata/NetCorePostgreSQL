namespace StudentGrades.Models
{
    using System.Collections.Generic;

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Activo { get; set; }

        public IEnumerable<Grade> Grades { get; set; }
    }
}
