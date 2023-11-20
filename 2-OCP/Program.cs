using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer() { Name = "Vishal", CustomerType = "Silver"};
            //c.Print();
            //if(c.CustomerType == "Silver")
            //{
            //    Console.WriteLine("Silver Customer");
            //}
            //else if(c.CustomerType == "Gold")
            //{
            //    Console.WriteLine("Gold Customer");
            //}

            //Customer c1 = new Customer() { Name = "Mahesh", CustomerType = "Gold" };
            //c1.Print();
            //if (c1.CustomerType == "Silver")
            //{
            //    Console.WriteLine("Silver Customer");
            //}
            //else if (c1.CustomerType == "Gold")
            //{
            //    Console.WriteLine("Gold Customer");
            //}

            Customer c1 = new SilverCustomer() { Name = "Vishal" };
            c1.Print();

            Customer c2 = new GoldCustomer() { Name = "Mahesh" };
            c2.Print();

            Customer c3 = new PlatinumCustomer() { Name = "Kunal"};
            c3.Print();

            Console.ReadLine();
        }
    }
}
