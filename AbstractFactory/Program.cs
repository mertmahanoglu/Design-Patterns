using AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            MailOperations mailOperations = new MailOperations(new Factory1());
            mailOperations.LogNCache();
            Console.ReadLine();
        }
    }
}
