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
            ArithProgression arith = new ArithProgression();
            Console.WriteLine("Арифметическая прогрессия.");
            Console.WriteLine("Введите начальное целочисленное значение."); 
            arith.setStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите целочисленный положительный шаг.");
            arith.setStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Следующее значение равно {0}.", arith.getNext());
            Console.WriteLine("Следующее значение равно {0}.", arith.getNext());
            Console.WriteLine("Следующее значение равно {0}.", arith.getNext());
            arith.reset();
            Console.WriteLine("Произошёл сброс до начального значения.");
            Console.WriteLine("Следующее значение равно {0}.", arith.getNext());
            Console.WriteLine("Следующее значение равно {0}.", arith.getNext());
            Console.ReadKey();

            GeomProgression geom = new GeomProgression();
            Console.WriteLine("Геометрическая прогрессия.");
            Console.WriteLine("Введите начальное целочисленное значение.");
            geom.setStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите целочисленный положительный шаг (множитель).");
            geom.setStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Следующее значение равно {0}.", geom.getNext());
            Console.WriteLine("Следующее значение равно {0}.", geom.getNext());
            Console.WriteLine("Следующее значение равно {0}.", geom.getNext());
            geom.reset();
            Console.WriteLine("Произошёл сброс до начального значения.");
            Console.WriteLine("Следующее значение равно {0}.", geom.getNext());
            Console.WriteLine("Следующее значение равно {0}.", geom.getNext());
            Console.ReadKey();
        }
    }
}
