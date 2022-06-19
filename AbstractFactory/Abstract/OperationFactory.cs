using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    public abstract class OperationFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }
}
