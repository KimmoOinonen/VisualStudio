using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.OnOff = true;
            radio.Volume = 7;
            radio.Frequency = 22000;
            Console.WriteLine(radio.ToString());
            Console.ReadLine();
        }
    }
}
