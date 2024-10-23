using OOP.Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logger
{
    internal abstract class LoggerFactory
    {
        public abstract LoggerI createLogger();

        public void logMessage(string message)
        {
            LoggerI logger = createLogger();
            logger.log(message);
        }
    }
}
