using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_EFDBFirstAppraoch_CRUD
{
    // our own Student entity part
    public partial class Student
    {
        public bool IsActive { get; set; }
    }
}