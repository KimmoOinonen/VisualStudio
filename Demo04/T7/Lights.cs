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
    class Lights
    {
        public bool OnOff { get; set; }
        public int BulbWatt { get; set; }
        public int BulbAmount { get; set; }
        public string BulbType { get; set; }

        public Lights(bool onOff, string bulbType, int bulbWatt, int bulbAmount)
        {
            OnOff = onOff;
            BulbWatt = bulbWatt;
            BulbAmount = bulbAmount;
            BulbType = bulbType;
        }

        public override string ToString()
        {
            return "Is light on or off : " + OnOff + " Type of bulb : " + BulbType + " Watt amount of bulb : " + BulbWatt + "W" + " Amount of bulbs : " + BulbAmount;
        }
    }
}
