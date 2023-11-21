using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP
{
    public interface ICustomer
    {
        void PrintTicket();        
    }

    public interface ICustomerV1 : ICustomer
    {
        void OrderFood();
    }
}
