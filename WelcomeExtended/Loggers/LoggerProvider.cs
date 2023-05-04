using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    internal class LoggerProvider : ILoggerProvider
    {
        public LoggerProvider()
        {
            return new HashLogger(categoryName);
        } 
    }
}
