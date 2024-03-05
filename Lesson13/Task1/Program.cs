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
            string a;
            double l, w, h;
            int f;
            Console.WriteLine("Введите адрес.");
            a = Console.ReadLine();
            Console.WriteLine("Введите длину.");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину.");
            w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту.");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число этажей.");
            f = Convert.ToInt32(Console.ReadLine());
            
            Building building = new Building(a, l, w, h);
            Console.WriteLine("Информация о здании без указания этажности:");
            Console.WriteLine(building.Print());
            MultiBuilding multibuilding = new MultiBuilding(a, l, w, h, f);
            Console.WriteLine("Информация о здании с указанием этажности:");
            Console.WriteLine(multibuilding.Print());
            Console.ReadKey();
        }
    }
}
