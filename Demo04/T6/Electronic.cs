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
    class Electronic : Shelf
    {
        public string DeviceType { get; set; }
        public double DeviceScreen { get; set; }
        public int DeviceMemory { get; set; }
        public string DeviceOS { get; set; }

        public Electronic(string itemName, int itemAmount, int shelfNum, string deviceType, double deviceScreen, int deviceMemory, string deviceOS) 
            :base(itemName, itemAmount, shelfNum)
        {
            DeviceType = deviceType;
            DeviceScreen = deviceScreen;
            DeviceMemory = deviceMemory;
            DeviceOS = deviceOS;
        }

        public override string ToString()
        {
            return base.ToString() + " Type of device : " + DeviceType + " Screen size : " + DeviceScreen + " inches " + " Memory size : " + DeviceMemory + " GB " + " Operating system : " + DeviceOS;
        }
    }
}
