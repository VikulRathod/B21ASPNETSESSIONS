using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIP
{
    // low level module
    public class UsersDAL : IUsersDAL
    {
        public void Insert()
        {
            // ado.net code
            Console.WriteLine("Data inserted successfully");
        }
    }
}
