using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_lab_3___4.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Range(18,40)]
        public int Age { get; set; }
        
        public int DeptNo { get; set; }
        [ForeignKey("DeptNo")]
       public virtual Department Department { get; set; }
       public virtual HashSet<StudentCourse> StudentCourses { get; set; }

    }
}
