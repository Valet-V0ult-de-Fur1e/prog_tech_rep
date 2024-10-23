using OOP.Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logger.ConsoleLogger
{
    internal class ConsoleLogger : LoggerI
    {
        static private protected int countLogs = 0;
        public void log(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
