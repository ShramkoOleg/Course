using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach(Product p in products)
            {
                if (p.Cost>maxProduct.Cost)
                {
                    maxProduct = p;
                }
            }
            Console.WriteLine($"Название самого дорого товара: {maxProduct.Name}");
            Console.ReadKey();
        }
    }
}
