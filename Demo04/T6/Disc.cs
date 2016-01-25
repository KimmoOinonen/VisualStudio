/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 22.1.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Disc : Shelf
    {
        public string DiscType { get; set; }
        public double Capacity { get; set; }

        public Disc(string itemName, int itemAmount, int shelfNum, string discType, double capacity) 
            :base(itemName,itemAmount,shelfNum)
        {
            DiscType = discType;
            Capacity = capacity;
        }

        public override string ToString()
        {
            return base.ToString() + " Type of the disc : " + DiscType + " Disc capacity : " + Capacity + " GB ";
        }

    }
}
