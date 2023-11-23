using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //Console.WriteLine(c1.Name);

            //Customer c2 = new SilverCustomer();
            //Console.WriteLine(c2.Name);

            //Customer c3 = new GoldCustomer();
            //Console.WriteLine(c3.Name);

            Console.WriteLine("Please Enter Customer Type");
            string input = Console.ReadLine();

            Customer c = CustomerFactory.Instance(input);

            //switch (input.ToUpper())
            //{
            //    case "GOLD":
            //        c = new GoldCustomer();
            //        break;
            //    case "SILVER":
            //        c = new SilverCustomer();
            //        break;
            //    default:
            //        c = new Customer();
            //        break;
            //}

            Console.WriteLine(c.Name);

            Console.ReadLine();
        }
    }
}
