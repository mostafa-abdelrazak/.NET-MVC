using Microsoft.EntityFrameworkCore;
using MVC_lab_3___4.Models;

namespace MVC_lab_3___4.Bll
{
    public class StudentBll :IEntity<Student>
    {
        MVC_lab_DBcontext db = new MVC_lab_DBcontext();
        public List<Student> getall()
        {
             return db.students.Include(a => a.Department).ToList();
        }
        public Student getbyid (int id)
        {
            return db.students.Include(a => a.Department).FirstOrDefault(c => c.ID == id);                       
        }
        public void add(Student s)
        {
            if (s != null)
            {
                db.students.Add(s);
                db.SaveChanges();
            }
            
        }
        public void deletebyid(int id)
        {
            var s = db.students.FirstOrDefault(s => s.ID == id);
            if (s != null)
            {
                db.students.Remove(s);
                db.SaveChanges();
            }
           
        }
        public void update(Student s)
        {
            if (s != null)
            {
                db.students.Update(s);
                db.SaveChanges();
            }
           
        }
    }
}
