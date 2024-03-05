using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int incorrect = 777;
        public bool isCorrect = true;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value == incorrect)
                {
                    isCorrect = false;
                }
                else
                {
                    gradus = value % 360;
                }
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value == incorrect)
                {
                    isCorrect = false;
                }
                else
                {
                    Gradus = Gradus + value / 60;
                    min = value % 60;
                }
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value == incorrect)
                {
                    isCorrect = false;
                }
                else
                {
                    Min = Min + value / 60;
                    sec = value % 60;
                }
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadian()
        {
            return (gradus + min / 60.0 + sec / 3600.0) / 180.0 * Math.PI;
        }
    }
}
