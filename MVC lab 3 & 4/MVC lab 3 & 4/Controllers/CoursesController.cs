using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_lab_3___4.Models;

namespace MVC_lab_3___4.Controllers
{
    public class CoursesController : Controller
    {
        MVC_lab_DBcontext db = new MVC_lab_DBcontext();
        public IActionResult Index()
        {
            var result = db.courses.Include(a => a.departments).ToList();
            return View(result);

        }
        public IActionResult details(int id)
        {
           var result =  db.courses.Include(a => a.departments).FirstOrDefault(a=>a.ID == id);
            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //this dosn't work i want to know why ?
          //  var dep = dbll.getbyid(id);
            var Course = db.courses.Include(a => a.departments).FirstOrDefault(a => a.ID == id);
            var x = db.departments.Include(a => a.Courses).ToList();

            var depsout = x.Except(Course.departments).ToList();
            ViewBag.DepsNotIn = new SelectList(depsout, "ID", "Name");
            ViewBag.DepsIn = new SelectList(Course.departments, "ID", "Name");

            return View(Course);
        }
        [HttpPost]
        public IActionResult Edit(Course s, int[] Add, int[] Remove)
        {
            var temp = db.courses.Include(a => a.departments).FirstOrDefault(a => a.ID == s.ID);
            foreach (int i in Add)
            {
                var item = db.departments.FirstOrDefault(a => a.ID == i);
                temp.departments.Add(item);
            }
            foreach (int i in Remove)
            {
                var item = db.departments.FirstOrDefault(a => a.ID == i);
                temp.departments.Remove(item);
            }
            db.SaveChanges();


            // dbll.update(s);
            return RedirectToAction("Index");
        }
    }
}
