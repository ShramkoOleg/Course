using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Linear
    {
        double k;
        double b;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0)
            {
                return "Коэффициент k = 0. Бесконечное множество решений.";
            }
            else
            {
                double r;
                r = -b / k;
                return $"Решение: {r}.";
            }
        }
    }
}
