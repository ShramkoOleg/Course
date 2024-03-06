using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue = currentValue + step;
            return currentValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
