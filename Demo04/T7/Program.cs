/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 23.1.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Rooms light1 = new Rooms(true, 4, 5, "Led", "Living room");
            Console.WriteLine(light1.ToString());

            Rooms light2 = new Rooms(false, 60, 3, "Halogen", "Kitchen");
            Console.WriteLine(light2.ToString());

            Console.ReadLine();
        }
    }
}
