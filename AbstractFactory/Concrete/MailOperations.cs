using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class MailOperations
    {
        OperationFactory _operationFactory;
        Caching _caching;
        Logging _logging;

        public MailOperations( OperationFactory operationFactory)
        {
            _operationFactory = operationFactory;
            _caching = _operationFactory.CreateCaching();
            _logging = _operationFactory.CreateLogger();
        }

        public void SendMail()
        {
            Console.WriteLine("Mail sent");
        }

        public void LogNCache()
        {
            _caching.Cache("Cache");
            _logging.Log("Log");
        }

    }
}
