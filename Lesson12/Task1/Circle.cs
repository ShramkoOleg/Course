using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circle
    {
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public string CheckPoint(double r, double x0, double y0, double x, double y)
        {
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) > r * r)
            {
                return "Точка не принадлежит кругу.";
            }
            else 
            {
                return "Точка принадлежит кругу.";
            }
        }
    }
}
