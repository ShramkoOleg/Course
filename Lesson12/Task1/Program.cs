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
            double r, x0, y0, x, y;
            double L, S;
            Console.WriteLine("Введите радиус окружности.");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра.");
            x0 = Convert.ToDouble(Console.ReadLine());
            y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки.");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            L = Circle.GetLength(r);
            Console.WriteLine("Длина окружности равна {0}.", L);
            S = Circle.GetSquare(r);
            Console.WriteLine("Площадь круга равна {0}.", S);
            Console.WriteLine(Circle.CheckPoint(r, x0, y0, x, y));
            Console.ReadKey();
        }
    }
}
