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
            List<Computer> computers = new List<Computer>()
            {
                new Computer() { Name = "1 Dell", ProcType = "Intel", ProcFreq = 2.3, Ram = 512, Hdd = 1024, Video = 256, Cost = 120.5, Num = 2 },
                new Computer() { Name = "2 IBM", ProcType = "Intel", ProcFreq = 2.3, Ram = 512, Hdd = 512, Video = 256, Cost = 130.0, Num = 2 },
                new Computer() { Name = "3 Asus", ProcType = "AMD", ProcFreq = 1.1, Ram = 256, Hdd = 512, Video = 256, Cost = 50.0, Num = 2 },
                new Computer() { Name = "4 MSI", ProcType = "AMD", ProcFreq = 1.3, Ram = 512, Hdd = 512, Video = 256, Cost = 100.0, Num = 2 },
                new Computer() { Name = "5 Lenovo", ProcType = "AMD", ProcFreq = 2.3, Ram = 512, Hdd = 512, Video = 256, Cost = 110.0, Num = 2 },
                new Computer() { Name = "6 Intel", ProcType = "Intel", ProcFreq = 2.3, Ram = 512, Hdd = 512, Video = 256, Cost = 120.0, Num = 30 }
            };

            Console.WriteLine("Введите название процессора.");
            string procType = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.ProcType == procType).ToList();
            Print(computers1);

            Console.WriteLine("Введите объём ОЗУ.");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.Ram >= ram).ToList();
            Print(computers2);

            Console.WriteLine("Список, упорядоченный по возрастанию цены.");
            List<Computer> computers3 = computers.OrderBy(x => x.Cost).ToList();
            Print(computers3);

            Console.WriteLine("Сгруппированные по типу процессора.");
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.ProcType);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Name} {c.ProcType} {c.ProcFreq} {c.Ram} {c.Hdd} {c.Video} {c.Cost} {c.Num}");
                }
            }

            Console.WriteLine("Самый дорогой компьютер.");
            Computer computers5 = computers.OrderByDescending(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{computers5.Name} {computers5.ProcType} {computers5.ProcFreq} {computers5.Ram} {computers5.Hdd} {computers5.Video} {computers5.Cost} {computers5.Num}");

            Console.WriteLine("Самый дешёвый компьютер.");
            Computer computers6 = computers.OrderByDescending(x => x.Cost).Last();
            Console.WriteLine($"{computers6.Name} {computers6.ProcType} {computers6.ProcFreq} {computers6.Ram} {computers6.Hdd} {computers6.Video} {computers6.Cost} {computers6.Num}");

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computers.Any(x => x.Num >= 30));

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach(Computer c in computers)
            {
                Console.WriteLine($"{c.Name} {c.ProcType} {c.ProcFreq} {c.Ram} {c.Hdd} {c.Video} {c.Cost} {c.Num}");
            }
            Console.WriteLine();
        }

    }
}
