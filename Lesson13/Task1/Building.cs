using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        string address;
        double length;
        double width;
        double heigth;

        string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        double Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                heigth = value;
            }
        }

        public Building(string address, double length, double width, double heigth)
        {
            this.Address = address;
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
        }
        public string Print()
        {
            return $"{address}; {length}; {width}; {heigth}";
        }
    }
}
