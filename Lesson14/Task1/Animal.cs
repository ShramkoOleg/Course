using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal()
        {
            Name = "Животное";
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
}
