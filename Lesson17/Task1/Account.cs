using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Account<T>
    {
        private T Num { get; set; }
        private double Balance { get; set; }
        private string Name { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Номер счёта: {0}. Имя владельца счёта: {1}. Баланс: {2}.", Num, Name, Balance);
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счёта.");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите имя.");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс.");
            Balance = Convert.ToDouble(Console.ReadLine());
        }

    }
}
