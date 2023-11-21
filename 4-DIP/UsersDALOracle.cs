using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIP
{
    public class UsersDALOracle : IUsersDAL
    {
        public void Insert()
        {
            Console.WriteLine("Oracle DB : Data inserted successfully");
        }
    }
}
