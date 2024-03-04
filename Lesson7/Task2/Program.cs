using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, S, V;
            Console.WriteLine("Введите длину ребра куба.");
            a = Convert.ToDouble(Console.ReadLine());
            GetParamsCube(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба равна {0}.", S);
            Console.WriteLine("Объём куба равен {0}.", V);
            Console.ReadKey();
        }
        static void GetParamsCube(double a, out double S, out double V)
        {
            S = 6 * a * a;
            V = a * a * a;
        }
    }
}
