using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);

            Console.ReadKey();
        }

        static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Факториал: {0}.", f);
        }

        static async void FactAsync(int n)
        {
            await Task.Run(() => Fact(n));
        }
    }
}
