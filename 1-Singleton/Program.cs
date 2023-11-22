using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //Customer c2 = new Customer();
            //Customer c3 = new Customer();

            Customer c1 = Customer.Instance;
            Customer c2 = Customer.Instance;
            //Customer c1 = Customer.GetInstance();
            //Customer c2 = Customer.GetInstance();

            if (c1 == c2)
            {
                Console.WriteLine("c1 & c2 are EQUAL");
            }
            else
            {
                Console.WriteLine("c1 & c2 are NOT EQUAL");
            }

            Customer c3 = Customer.Instance;

            if (c1 == c3)
            {
                Console.WriteLine("c1 & c3 are EQUAL");
            }
            else
            {
                Console.WriteLine("c1 & c3 are NOT EQUAL");
            }

            Customer c4 = Customer.Instance;
            Customer c5 = Customer.Instance;
            Customer c6 = Customer.Instance;
            Customer c7 = Customer.Instance;

            if(c5 == c6 && c5 == c7)
            {
                Console.WriteLine("c5, c6 & c7 are EQUAL");
            }
            else
            {
                Console.WriteLine("c5, c6 & c7 are NOT EQUAL");
            }

            Console.ReadLine();
        }
    }
}
