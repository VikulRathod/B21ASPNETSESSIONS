using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_ViewToController.Models
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}