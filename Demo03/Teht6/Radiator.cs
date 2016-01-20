/*
* Copyright (C) Kimmo 
*
* Homework project in Object-Oriented and GUI Programming.
* This is class program for a little project simulating radiator.
*
* Created: 19.1.2016.
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Radiator
    {
        // properties
        public bool On { get; set; }
        public bool Off { get; set; }
        public int Power { get; set; }
        public int RoomTemp { get; set; }

        // method printing data
        public void PrintData()
        {
            Console.WriteLine("Radiator:");
            Console.WriteLine("Radiator is on : " + On);
            Console.WriteLine("Radiator is off : " + Off);
            Console.WriteLine("Radiator's power is : " + Power);
            Console.WriteLine("Room temperature is : " + RoomTemp);
        }
    }
}
