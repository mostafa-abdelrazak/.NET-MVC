using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_lab_3___4.Bll;
using MVC_lab_3___4.Models;
using System.Linq;

namespace MVC_lab_3___4.Controllers
{
    public class StudentsController : Controller
    {

        IEntity<Student> Sbll; // = new StudentBll();
        IEntity<Department> dbll; // = new DepartmentBll();
        public StudentsController(IEntity<Student> _Sbll , IEntity<Department> _dbll)
        {
            Sbll = _Sbll;
            dbll = _dbll;
        }
        public IActionResult Index()
        {
            var result = Sbll.getall();
            return View(result);
        }
        public IActionResult Details(int id)
        {
            var result = Sbll.getbyid(id);
            // var r = dB.students.Include("Department").FirstOrDefault(c=>c.ID == id);
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var deps = dbll.getall();
            ViewBag.deps = new SelectList(deps, "ID","Name") ;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                Sbll.add(s);
                return RedirectToAction("Index");
            }
            var deps = dbll.getall();
            ViewBag.deps = new SelectList(deps, "ID", "Name");
            return View();
            
        }
        
        public IActionResult delete(int id)
        {
            var s = Sbll.getbyid(id);
            return View(s);
        }
        [ActionName("delete"),HttpPost]
        public IActionResult deleteconfirm(int id)
        {
            Sbll.deletebyid(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var deps = dbll.getall();
            ViewBag.deps = new SelectList(deps, "ID", "Name");
            var s = Sbll.getbyid(id);
            return View(s);
        }
        [HttpPost]
        public IActionResult Edit(Student s)
        {
            Sbll.update(s);
            return RedirectToAction("Index");
        }


    }
}
