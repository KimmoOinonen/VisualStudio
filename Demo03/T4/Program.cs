using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Auto";
            vehicle.Speed = 100;
            vehicle.Tyres = 4;
            vehicle.PrintData();
            Console.WriteLine(vehicle.ToString());

            Console.ReadLine();
        }
    }
}
