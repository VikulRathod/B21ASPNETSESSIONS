﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryPattern
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer()
        {
            Name = "Regular Customer";
        }
    }
}
