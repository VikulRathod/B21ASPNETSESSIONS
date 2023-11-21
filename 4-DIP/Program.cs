using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UsersBL bl = new UsersBL(new UsersDAL());
            UsersBL bl = new UsersBL(new UsersDALOracle());
            bl.Insert();

            Console.ReadLine();
        }
    }
}
