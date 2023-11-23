using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryPattern
{
    public class CustomerFactory
    {
        static Dictionary<string, Customer> customers;

        static CustomerFactory()
        {
            customers = new Dictionary<string, Customer>();
            customers.Add("SILVER", new SilverCustomer());
            customers.Add("GOLD", new GoldCustomer());
            customers.Add("PLATINUM", new PlatinumCustomer());
        }

        public static Customer Instance(string input)
        {
            //switch (input.ToUpper())
            //{
            //    case "GOLD":
            //        return new GoldCustomer();
            //    case "SILVER":
            //        return new SilverCustomer();
            //    case "PLATINUM":
            //        return new PlatinumCustomer();
            //    default:
            //        return new Customer();
            //}

            if (customers.ContainsKey(input.ToUpper()))
            {
                return customers[input.ToUpper()];
            }
            else
            {
                return new Customer();
            }
        }
    }
}
