using MyFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public object EmployeeName { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FirstName = "Vishal";
            ViewBag.LastName = "Senewiratne";
            ViewBag.Address = "Mars 405";

            TempData["Employee"] = "Raouf Yasin";
           
            return View();
        }

        public ActionResult GetEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {

             new Employee()
             {
                EmployeeID = 1,
                EmployeeName = "Chris Carmona",
                Address = "403 Bark",
                DateofJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsElligibleForLoan = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
             },

             new Employee()
             {
                EmployeeID = 2,
                EmployeeName = "Vish Sene",
                Address = "234 Tree",
                DateofJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsElligibleForLoan = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
             },

             new Employee()
             {
                EmployeeID = 3,
                EmployeeName = "Med Enriquez",
                Address = "403 Bark",
                DateofJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsElligibleForLoan = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
             },

             new Employee()
             {
                EmployeeID = 4,
                EmployeeName = "Brion Borja",
                Address = "403 Bark",
                DateofJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsElligibleForLoan = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
             },

             new Employee()
             {
                EmployeeID = 5,
                EmployeeName = "Paul Musat",
                Address = "403 Bark",
                DateofJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsElligibleForLoan = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
             }

            };
            

            ViewBag.Employees = employees;
            return View();
        } 
       
    }
}