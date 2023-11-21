using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP
{
    public class GoldCustomer: Customer, ICustomer
    {
       // public int TicketAmount { get; set; }

        public GoldCustomer()
        {
            TicketAmount = 250;
        }

        //public void ShowsTimings()
        //{
        //    Console.WriteLine("** TODAY's SHOWS **");
        //}

        //public int GetTicketAmount()
        //{
        //    return TicketAmount;
        //}

        public void PrintTicket()
        {
            Console.WriteLine("** Gold Ticket Printed **");
        }
    }
}
