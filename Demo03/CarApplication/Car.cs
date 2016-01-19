using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // field member

        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }

        // constructor
        public Car()
        {
            FuzzyDices = true;
        }

        // parametric constructor
        public Car(string model)
        {
            Model = model;
        }

        // method displays car data
        public void PrintData()
        {
            Console.WriteLine("Car data:");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzyDices : " + FuzzyDices);
        }

        // method gives more speed
        public void Accelerate(int newSpeed)
        {
            Speed += newSpeed;
        }
    }
}
