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
            double a, b, c;
            a = 0;
            b = 0;
            c = 0;
            int op;
            bool err = false;
            Console.WriteLine("Введите первое число.");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.ReadKey();
                err = true;
            }
            Console.WriteLine("Введите второе число.");
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.ReadKey();
                err = true;
            }
            Console.WriteLine("Введите код операции: 1 - сложение, 2 - вычитание, 3 - произведение, 4 - частное.");
            op = Convert.ToInt32(Console.ReadLine());
            if (err == true)
            {
                Console.WriteLine("Невозможно совершить операцию из-за ошибки в вводе данных.");
                Console.ReadKey();
            }
            else
            {
                switch (op)
                {
                    case 1:
                        {
                            c = a + b;
                            Console.WriteLine("Сумма равна {0}.", c);
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            c = a - b;
                            Console.WriteLine("Разность равна {0}.", c);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            c = a * b;
                            Console.WriteLine("Произведение равно {0}.", c);
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            c = a / b;
                            if (Double.IsInfinity(c) == true)
                            {
                                Console.WriteLine("Ошибка. Деление на ноль.");
                                err = true;
                            }
                            if (err == false)
                            {
                                Console.WriteLine("Частное равно {0}.", c);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.ReadKey();
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером.");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}
