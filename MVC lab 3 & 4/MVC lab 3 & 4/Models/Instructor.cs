namespace MVC_lab_3___4.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual HashSet<Department> Departments { get; set; }
        public virtual HashSet<Course> Courses { get; set; }


    }
}
