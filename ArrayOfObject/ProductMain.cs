using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObject
{
    internal class ProductMain
    {
        static void Main(string[] args)
        {
            Product[] prod = new Product[5]
            {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Mouse", Price = 50 },
            new Product { Id = 3, Name = "Keyboard", Price = 150 },
            new Product { Id = 4, Name = "Monitor", Price = 700 },
            new Product { Id = 5, Name = "Printer", Price = 300 }
            };

            Console.WriteLine("Displaying all products using for loop:");
            for (int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine(prod[i]);
            }


            Console.WriteLine("\nDisplaying all products using foreach loop:");
            foreach (Product p in prod)
            {
                Console.WriteLine(p);
            }

            
            Console.WriteLine("\nDisplaying products with price > 500:");
            foreach (Product p in prod)
            {
                if (p.Price > 500)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
