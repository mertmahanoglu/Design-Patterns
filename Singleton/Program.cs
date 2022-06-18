using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cant create new object
            //ProductOperations productOperations = new ProductOperations();
            var productOperations = ProductOperations.CreateAsSingleton();
            productOperations.SaveProduct();
        }
    }

    class ProductOperations
    {
        static ProductOperations _productOperations;

        //Prevent to create new object 
        private ProductOperations()
        {

        }

        public static ProductOperations CreateAsSingleton()
        {
            return _productOperations ?? (_productOperations = new ProductOperations());
        }

        public void SaveProduct()
        {
            Console.WriteLine("Product Saved");
        }

    }
}
