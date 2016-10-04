using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Threading;

namespace Log4Net
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            Logger.Debug("Entry main...");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                Logger.DebugFormat("Value of I = {0}", i);               
            }
            
            Logger.Debug("Exit main...");
            Console.ReadLine();
        }
    }
}
