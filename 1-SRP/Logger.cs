using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SRP
{
    internal class Logger
    {
        public void Log(string message)
        {
            File.WriteAllText(@"logs.txt", message);
        }
    }
}
