using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog()
            : base()
        {
            Name = "Собака";
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
