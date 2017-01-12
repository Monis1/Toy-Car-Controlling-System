using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bms
{
    class Temp
    {
        double rtemp, ktemp;

        public double Ktemp
        {
            get { return ktemp; }
            set { ktemp = value; }
        }

        public double Rtemp
        {
            get { return rtemp; }
            set { rtemp = value; }
        }

    }
}
