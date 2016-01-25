/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 20.1.2016
 * Author: Kimmo Oinonen
 */
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
