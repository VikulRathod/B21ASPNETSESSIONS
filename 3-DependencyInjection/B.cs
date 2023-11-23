using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DependencyInjection
{
    public class B : IB
    {
        public void Print()
        {
            Console.WriteLine("B Class Print() Method");
        }
    }
}
