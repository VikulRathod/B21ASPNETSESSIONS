using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP
{
    public class PlatinumCustomer : Customer, ICustomerV1
    {
        public void OrderFood()
        {
            Console.WriteLine("** Food at seat **");
        }

        public void PrintTicket()
        {
            Console.WriteLine("** Platinum Ticket Printed **");
        }


    }
}
