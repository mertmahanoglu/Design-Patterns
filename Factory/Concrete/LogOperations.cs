using Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Concrete
{
    public class LogOperations
    {
        private ILoggerFactory _loggerFactory;
        public LogOperations(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void SaveLog()
        {
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
