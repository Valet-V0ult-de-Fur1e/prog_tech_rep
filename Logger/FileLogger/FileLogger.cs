using OOP.Logger.Interfaces;
using System.IO;
namespace OOP.Logger.FileLogger
{
    internal class FileLogger : LoggerI
    {
        static private protected int countLogs = 0;
        public void log(string messege)
        {
            StreamWriter sw = new StreamWriter(string.Format("{0}.log", countLogs));
            countLogs++;
            sw.Write(messege);
            sw.Close();
        }
    }
}
