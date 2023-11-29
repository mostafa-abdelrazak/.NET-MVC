using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_lab_3___4.Bll;
using MVC_lab_3___4.Models;
using System.Linq;

namespace MVC_lab_3___4.Controllers
{
    public class DepartmentsController : Controller
    {
        IEntity<Department> dbll; // = new DepartmentBll();
        MVC_lab_DBcontext db; // = new MVC_lab_DBcontext();
       public  DepartmentsController(IEntity<Department> _dbll , MVC_lab_DBcontext _db)
        {
            dbll = _dbll;
            db = _db;
        }
        public IActionResult Index()
        {
            var deps = dbll.getall();

            return View(deps);
        }
        public IActionResult Details(int id)
        {
            var dep = dbll.getbyid(id);

            return View(dep);
        }
        [HttpGet]
        public IActionResult Create()
        {
                 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department s)
        {
            if (ModelState.IsValid)
            {
                dbll.add(s);
                return RedirectToAction("Index");
            }
            return View();
            
        }
        public IActionResult delete(int id)
        {
            var s = dbll.getbyid(id);
            return View(s);
        }
        [ActionName("delete"), HttpPost]
        public IActionResult deleteconfirm(int id)
        {
            dbll.deletebyid(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //this dosn't work i want to know why ?
            var dep = dbll.getbyid(id);
            var depp = db.departments.Include(a=>a.Courses).FirstOrDefault(a=> a.ID == id);
            var x = db.courses.Include(a => a.departments).ToList();
           
            var cnotin = x.Except(depp.Courses).ToList();
            ViewBag.CoursesNotIn = new SelectList(cnotin ,"ID","name");
            ViewBag.CoursesIn = new SelectList(dep.Courses, "ID", "name");

            return View(dep);
        }
        [HttpPost]
        public IActionResult Edit(Department s, int[] Add , int[] Remove)
        {
            var temp = db.departments.Include(a=>a.Courses).FirstOrDefault(a=>a.ID== s.ID);
            foreach (int i in Add )
            {
                var item =   db.courses.FirstOrDefault(a=>a.ID==i);
                temp.Courses.Add(item);
            }
            foreach (int i in Remove)
            {
                var item = db.courses.FirstOrDefault(a => a.ID == i);
                temp.Courses.Remove(item);
            }
            db.SaveChanges();

            
           // dbll.update(s);
            return RedirectToAction("Index");
        }

    }
}
