using Microsoft.EntityFrameworkCore;
using MVC_lab_3___4.Models;

namespace MVC_lab_3___4.Bll
{
    public class DepartmentBll :IEntity<Department>
    {
        MVC_lab_DBcontext db = new MVC_lab_DBcontext();
        public List<Department> getall()
        {
            return db.departments.Include(c => c.Students).Include(c=>c.Courses).ToList();
        }

        public Department getbyid(int id)
        {
            return db.departments.Include(c => c.Students).Include(c=>c.Courses).FirstOrDefault(c => c.ID == id);
        }

        public void add(Department s)
        {
            if (s != null)
            {
                db.departments.Add(s);
                db.SaveChanges();
            }

        }
        public void deletebyid(int id)
        {
            var s = db.departments.Include(c => c.Students).Include(c => c.Courses).FirstOrDefault(s => s.ID == id);
            if (s != null)
            {
                db.departments.Remove(s);
                db.SaveChanges();
            }

        }
        public void update(Department s)
        {
            if (s != null)
            {
                db.departments.Update(s);
                db.SaveChanges();
            }

        }
    }
}
