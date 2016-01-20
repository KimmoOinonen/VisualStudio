using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Radio
    {
        public bool OnOff;

        private readonly int maxVolume = 9;
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;

        private int volume;
        private double frequency;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume) volume = value;
                else
                {
                    Console.WriteLine("Too much volume - set to max!");
                    volume = maxVolume;
                }
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= maxFrequency && value >= minFrequency) frequency = value;
                else
                {
                    Console.WriteLine("Too much or too little frequency - set to min!");
                    frequency = minFrequency;
                }
            }
        }

        public override string ToString()
        {
            return "Radio is on : " + OnOff + " Frequency is : " + Frequency + " Volume is : " + Volume;
        }
    }
}
