using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SRP Example");
            Insert();

            Console.ReadLine();
        }

        // this method will going to insert data to database
        static void Insert()
        {
            try
            {
                // ado.net code
                Console.WriteLine("Data inserted to database");
            }
            catch (Exception ex)
            {
                // File.WriteAllText(@"logs.txt", ex.Message);
                Logger log = new Logger();
                log.Log(ex.Message);
            }
        }
    }
}
