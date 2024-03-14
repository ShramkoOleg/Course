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
        const int n = 6;
        const int m = 5;
        static int[,] path = { { 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 0 } };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardener2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{path[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Gardener1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -1;
                        Thread.Sleep(delay);
                    }
                    else
                        break;
                }
            }
        }

        static void Gardener2()
        {
            for (int j = m - 1; j >= 0; j--)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                    else
                        break;
                }
            }
        }
    }
}
