using OOP.Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logger.FileLogger
{
    internal class FileLoggerFactory : LoggerFactory
    {
        public override LoggerI createLogger()
        {
            return new FileLogger();
        }
    }
}
