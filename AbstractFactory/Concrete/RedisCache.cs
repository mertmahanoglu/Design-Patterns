using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class RedisCache : Caching
    {
        public override void Cache(string message)
        {
            Console.WriteLine("Cached by Redis");
        }
    }
}
