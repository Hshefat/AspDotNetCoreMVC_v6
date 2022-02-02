using System.ComponentModel.DataAnnotations;

namespace CRUD_v6_1.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherAddress { get; set; }
        public int TeacherAge { get; set; }

        public List<Subject> SubjectTeachers { get; set; } = new List<Subject>();
    }
}
