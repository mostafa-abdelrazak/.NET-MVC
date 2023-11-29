using Microsoft.AspNetCore.Mvc;
using MVC_lab_1.Models;

namespace MVC_lab_1.Controllers
{
    public class Lab1Controller : Controller
    {
        public IActionResult index ()
        {
            return View();
        }
        [HttpGet]
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add(int num1,int num2)
        {
            ViewBag.result = num1+num2;

            return View();
        }
        public string data (string fname, string lname, int id ) 
        {
            return fname + "  " + lname + "  " + id.ToString();
        }
        public IActionResult show()
        {

            return View();
           // return fname + "  " + lname + "  " + id.ToString();
        }
        public IActionResult display(string name , int id , int age)
        {
            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.id = id;
            // ViewData

            List<object> list = new List<object>() { name , age , id };

            
            return View(list);
            // return fname + "  " + lname + "  " + id.ToString();
        }
        public IActionResult students()
        {   
            Student s1 = new Student() { Id=1 , Name = "mostafa"};
            Student s2 = new Student() { Id = 2, Name = "mohamed" };
            Student s3 = new Student() { Id = 3, Name = "ahmed" };
            Student s4 = new Student() { Id = 4, Name = "ali" };
            List<Student> students = new List<Student>() {s1,s2,s3,s4};
            
            return View(students);

        }

    }
}
