/*
* Copyright (C) Kimmo Oinonen
*
* Homework project in Object-Oriented and GUI Programming.
* This is little program simulating radiator.
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
    class Program
    {
        static void Main(string[] args)
        {
            Radiator radiator = new Radiator();
            radiator.On = true;
            radiator.Off = false;
            radiator.Power = 5;
            radiator.RoomTemp = 22;
            radiator.PrintData();

            Console.ReadLine();
        }
    }
}
