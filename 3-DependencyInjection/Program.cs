using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace _3_DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A a = new A(new B());
            //A a = new A(new C());
            //a.Print();

            //A a = new A();
            //a.Inject = new B();
            //a.Print();

            //A a = new A();
            //a.Inject(new B());
            //a.Print();

            // A a = new A();

            IUnityContainer unity = new UnityContainer();
            // unity.RegisterType<IB, B>();
            unity.RegisterType<IB, C>();
            A a = unity.Resolve<A>();
            a.Print();


            Console.ReadLine();
        }
    }
}
