using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
}
