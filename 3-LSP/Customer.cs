using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP
{
    public abstract class Customer
    {
        public int TicketAmount { get; set; }

        public void ShowsTimings()
        {
            Console.WriteLine("** TODAY's SHOWS **");
        }

        public int GetTicketAmount()
        {
            return TicketAmount;
        }

        // public abstract void PrintTicket();
    }
}
