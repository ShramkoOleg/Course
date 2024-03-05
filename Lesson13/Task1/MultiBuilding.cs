using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed class MultiBuilding : Building
    {
        int floors;
        int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                floors = value;
            }
        }

        public MultiBuilding(string address, double length, double width, double heigth, int floors)
            : base(address, length, width, heigth)
        {
            this.Floors = floors;
        }

        public string Print()
        {
            string result = base.Print();
            result = result + $"; {floors}";
            return result;
        }
    }
}
