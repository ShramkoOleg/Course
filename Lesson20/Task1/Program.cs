using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            double r;
            
            Console.WriteLine("Введите радиус.");
            r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate= Length;
            myDelegate += Square;
            myDelegate += Volume;
            myDelegate(r);
            Console.ReadKey();
        }

        static double Length(double r)
        {
            double l = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности: {0}.", l);
            return l;
        }

        static double Square(double r)
        {
            double s = Math.PI * r * r;
            Console.WriteLine("Площадь круга: {0}.", s);
            return s;
        }

        static double Volume(double r)
        {
            double v = (4.0 / 3.0) * Math.PI * r * r * r;
            Console.WriteLine("Объём шара: {0}.", v);
            return v;
        }
    }
}
