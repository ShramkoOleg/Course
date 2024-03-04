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
            double S1, S2;
            Console.WriteLine("Введите длины трёх сторон первого треугольника.");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            S1 = GetSquare(a1, b1, c1);
            Console.WriteLine("Введите длины трёх сторон второго треугольника.");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            S2 = GetSquare(a2, b2, c2);

            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше.");
            }
            else
            {
                if (S1 < S2)
                {
                    Console.WriteLine("Площадь второго треугольника больше.");
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны.");
                }
            }
            Console.ReadKey();
        }
        static double GetSquare(double a, double b, double c)
        {
            double p, S;
            p = (a + b + c) / 2.0;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
