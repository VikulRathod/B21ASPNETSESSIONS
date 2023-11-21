using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SilverCustomer sc = new SilverCustomer();
            //sc.ShowsTimings();
            //int i = sc.GetTicketAmount();
            //Console.WriteLine($"Ticket Amount is : {i}");
            //sc.PrintTicket();

            //GoldCustomer gc = new GoldCustomer();
            //gc.ShowsTimings();
            //i = gc.GetTicketAmount();
            //Console.WriteLine($"Ticket Amount is : {i}");
            //gc.PrintTicket();

            //Customer c = new SilverCustomer();
            //c.PrintTicket();
            //Customer c1 = new GoldCustomer();
            //c1.PrintTicket();

            List<Customer> customers = new List<Customer>();
            customers.Add(new SilverCustomer());
            customers.Add(new GoldCustomer());
            customers.Add(new EnquiryCustomer());

            foreach (Customer c in customers)
            {
                c.ShowsTimings();
                Console.WriteLine($"Ticket Amount is : {c.GetTicketAmount()}");
                // c.PrintTicket();
            }

            List<ICustomer> customers1 = new List<ICustomer>();
            customers1.Add(new SilverCustomer());
            customers1.Add(new GoldCustomer());
            // customers1.Add(new EnquiryCustomer());
            customers1.Add(new PlatinumCustomer());

            Console.ReadLine();
        }
    }
}
