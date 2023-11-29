using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_lab_3___4.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
       // [ForeignKey("StudentId")]
        public virtual HashSet<Student> Students { get; set; }
        public virtual HashSet<Course> Courses { get; set; }
        public virtual HashSet<Instructor> Instructors { get; set; }
        //public override bool Equals(object? obj)
        //{
        //    if (obj == null) return false;  
        //    Department other = obj as Department;
        //    if (other == null) return false;
        //    if (this.ID != other.ID) return false;
        //    if (this.Name != other.Name) return false;
        //    return true;
        //    return base.Equals(obj);
        //}
    }
}
