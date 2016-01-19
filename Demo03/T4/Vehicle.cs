using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // method prints vehicle data
        public void PrintData()
        {
            Console.WriteLine("Vehicle data : ");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Speed : " + Speed);
            Console.WriteLine("Tyres : " + Tyres);
        }

        // method returns heater data
        public override string ToString()
        {
            return "Vehicle : " + Name + " Speed : " + Speed + " Tyres : " +Tyres;
        }
    }
}
