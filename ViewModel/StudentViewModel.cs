using MyFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApplication.ViewModel
{
    public class StudentViewModel
    {
        public Student Student{ get; set; }
        public IEnumerable<Subjects> Subjects{ get; set; }
    }
}