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
            double radian;
            Console.WriteLine("Введите целочисленные значения для градусов, минут, секунд угла.");
            int gr = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gr, m, s);
            if (angle.isCorrect == false)
            {
                Console.WriteLine("Введено некорректное значение. Программа окончена.");
                Console.ReadKey();
            }
            else
            {
                radian = angle.ToRadian();
                Console.WriteLine("Угол в радианах равен {0}", radian);
                Console.ReadKey();
            }


        }
    }
}
