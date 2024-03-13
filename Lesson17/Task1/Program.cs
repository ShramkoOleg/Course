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
            Account<int> account1 = new Account<int>();
            account1.Input();

            Account<string> account2 = new Account<string>();
            account2.Input();

            account1.GetInfo();

            account2.GetInfo();

            Console.ReadKey();
        }
    }
}
