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
            double[] array = new double[7];
            double s = 0;
            double av;
            Console.WriteLine("Введите элементы массива поочерёдно.");
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                s = s + array[i];
            }
            av = s / 7;
            Console.WriteLine("Среднее арифметическое равно {0}.", av);
            Console.ReadKey();
        }
    }
}
