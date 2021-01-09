using MyFirstWebApplication.Models;
using MyFirstWebApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApplication.Controllers
{
    public class StudentController : Controller
    { 
        public ActionResult GetStudent()
        {
    
            var student = new Student() { StudentID = 1, StudentName = "Raouf", Address = "Istanbul" };
            var subjects = new List<Subjects>()
            {
                new Subjects(){Id=1, Name="Computer Programming" },
                new Subjects(){Id=2, Name="Database Analysis" },
                new Subjects(){Id=3, Name="Fundamental of Algorithm" },

            };

            var viewModel = new StudentViewModel()
            {
                Student = student,
                Subjects = subjects
            };

            return View(viewModel);

        }

        public ActionResult CreateStudent()
        {
            var student = new Student(){ StudentID = 1, StudentName = "Ben", Address = "Montreal"};
            return View(student);
        }

        public ActionResult SingleStudent()
        {
            return View();
        }

        public ActionResult EditStudent(int id)
        {
            return Content("Student Id:" + id);
        }

        [Route("student/passingyear/{month:range(1,12)}/{year}")]

        public ActionResult ByPassingYear(int month, int year)
        {
            return Content("Month: " + month + "Year: " + year);
        }
    }
}