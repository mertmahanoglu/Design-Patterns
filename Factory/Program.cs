using Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            LogOperations logOperations = new LogOperations(new Log4NetFactory());

            logOperations.SaveLog();

            Console.ReadLine();
        }
    }
}
