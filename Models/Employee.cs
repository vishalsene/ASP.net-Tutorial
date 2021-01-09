using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApplication.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName{ get; set; }
        public string Address{ get; set; }
        public DateTime DateofJoining{ get; set; }
        public int MartialStatus{ get; set; }
        public bool IsElligibleForLoan{ get; set; }
        public decimal Salary{ get; set; }
        public string CreatedBy{ get; set; }
        public DateTime CreatedDate{ get; set; }
    }
}