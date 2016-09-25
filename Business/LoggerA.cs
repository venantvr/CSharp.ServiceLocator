using System;
using Business.Interfaces;

namespace Business
{
    public class LoggerA : ILogger
    {
        #region ILogger Members

        public void Log()
        {
            Console.WriteLine(@"Something");
        }

        #endregion
    }
}