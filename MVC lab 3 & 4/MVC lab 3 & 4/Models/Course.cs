using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_lab_3___4.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }  

        public virtual HashSet<Department> departments { get; set; }
        public virtual HashSet<StudentCourse> StudentCourses { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Course other = obj as Course;
            if (other == null) return false;
            if (this.ID != other.ID) return false;
            if (this.name != other.name) return false;
            return true;
            return base.Equals(obj);
        }
    }
}
