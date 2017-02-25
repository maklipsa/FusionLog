using NLog;

namespace FusionLogLib
{
    public class LibraryClass
    {
        private static readonly Logger logger = LogManager.GetLogger("Console");

        public static void SayHi()
        {
            logger.Info("Hi!");
        }
    }
}