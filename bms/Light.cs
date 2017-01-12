using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bms
{
    class Light
    {
        public static bool state;

        public bool State
        {
            get { return state; }
            set { state = value; }
        }
        double intensity, voltage;

        public double Voltage
        {
            get { return voltage; }
            set { voltage = value; }
        }

        public double Intensity
        {
            get { return intensity; }
            set { intensity = value; }
        }

    }
}
