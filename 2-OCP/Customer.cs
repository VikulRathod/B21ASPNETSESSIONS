using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OCP
{
    //internal class Customer
    //{
    //    public string Name { get; set; }
    //    public string CustomerType { get; set; }
    //    public void Print()
    //    {
    //        // Console.WriteLine(Name);
    //        if(CustomerType == "Silver")
    //        {
    //            Console.WriteLine($"{Name} : Silver Customer");
    //        }
    //        else if (CustomerType == "Gold")
    //        {
    //            Console.WriteLine($"{Name} : Gold Customer");
    //        }
    //    }
    //}

    public class Customer
    {
        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"{Name} : Normal Customer");
        }
    }

    public class SilverCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine($"{Name} : Silver Customer");
        }
    }
    public class GoldCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine($"{Name} : Gold Customer");
        }
    }
    public class PlatinumCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine($"{Name} : Platinum Customer");
        }
    }
}
