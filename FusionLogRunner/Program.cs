using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace FusionLogRunner
{
    class Program
    {
        private static Logger logger = NLog.LogManager.GetLogger("Console");
        static void Main(string[] args)
        {
            logger.Info("Started");
            FusionLogLib.LibraryClass.SayHi();
            Console.ReadKey();
        }
    }
}

