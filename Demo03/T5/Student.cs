using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Student
    {
        // properties
        public string Name { get; set; }
        public string Number { get; set; }
        public string Gnumber { get; set; }
        public int Age { get; set; }
        public bool Listening { get; set; }
        public bool Working { get; set; }

        // method prints students data
        public void PrintData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Number : " + Number);
            Console.WriteLine("Group number : " + Gnumber);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Is student listening : " + Listening);
            Console.WriteLine("Is student working : " + Working);
        }

    }
}
