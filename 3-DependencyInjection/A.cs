using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DependencyInjection
{
    public class A
    {
        IB _b;
        public A(IB b) // using constructor
        {
            _b = b;
        }

        //public IB Inject // using property
        //{
        //    set
        //    {
        //        _b = value;
        //    }
        //}

        //public void Inject(IB b) // using method
        //{
        //    _b = b;
        //}

        public void Print()
        {
            // B b = new B();
            _b.Print();
        }
    }
}
