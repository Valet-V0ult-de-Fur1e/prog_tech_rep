using OOP.Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logger.ConsoleLogger
{
    internal class ConsoleLoggerFactory : LoggerFactory
    {
        public override LoggerI createLogger()
        {
            return new ConsoleLogger();
        }
    }
}
