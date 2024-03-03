using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, sq;
            int sum = 0;
            int i;
            Console.WriteLine("Введите число.");
            N = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= N; i++)
            {
                sum = sum + (2 * i - 1);
                Console.WriteLine("Текущее значение суммы составляет {0}.", sum);
            }
            sq = sum;
            Console.WriteLine("Квадрат числа равен {0}.", sq);
            Console.ReadKey();
        }
    }
}
