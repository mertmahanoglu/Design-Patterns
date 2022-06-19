using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class NhLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged by NhLogger");
        }
    }
}
