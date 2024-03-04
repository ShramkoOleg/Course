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
            Console.WriteLine("Введите предложение без знаков препинания.");
            string str = Console.ReadLine();
            string strMod = "";
            string strRev = "";
            string[] strArray;
            strArray = str.Split();
            foreach (string s in strArray)
            {
                strMod = strMod + s;
            }
            foreach (char c in strMod)
            {
                strRev = c + strRev;
            }
            if (String.Equals(strRev, strMod, StringComparison.CurrentCultureIgnoreCase) == true)
            {
                Console.WriteLine("Предложение является палиндромом.");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом.");
            }
            Console.ReadKey();
        }
    }
}
