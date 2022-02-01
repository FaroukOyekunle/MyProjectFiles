using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebAppDemo.Controllers
{
    public class StudentController: Controller
    {
        public List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Opeyemi",
                Age = 21,
                Class = "Primary One"
            },
            new Student
            {
                Id = 2,
                Name = "Olawale",
                Age = 22,
                Class = "Primary Two"
            },
            new Student
            {
                Id = 3,
                Name = "shola",
                Age = 23,
                Class = "Primary Four"
            }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(students);
        }
        public IActionResult Details(int id)
        {
            var Output = students.SingleOrDefault(student => student.Id == id);
            return View(Output);
        }
    }
}
