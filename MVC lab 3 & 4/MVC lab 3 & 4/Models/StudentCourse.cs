using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_lab_3___4.Models
{
    public class StudentCourse 
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public  int? degree { get; set; }
        [ForeignKey("StudentId")]
        public Student  student { get; set; }
        [ForeignKey("CourseId")]
        public Course   course { get; set; }
    }
}
