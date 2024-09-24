using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
namespace ConsoleApp5
{


    internal class Program
    {
        static void Main(string[] args)
        {
           ShopContext shopContext = new ShopContext();

            var WorkerInShop = shopContext.Workers.Select(worker => new
            {
                worker.Name,
                worker.Salary,
                worker.SurName
            });

            foreach (var w in WorkerInShop)
            {
                Console.WriteLine($"Worker {w}");
            }



            var ShopProduct =  shopContext.Products.Select(p => p);
            foreach (var product in ShopProduct) { 
                Console.WriteLine($"Product {product}");
            }

        }
    }
}
