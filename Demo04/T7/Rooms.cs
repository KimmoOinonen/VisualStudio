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
    class Rooms : Lights
    {
        public string RoomName { get; set; }

        public Rooms(bool onOff, int bulbWatt, int bulbAmount, string bulbType, string roomName)
            :base(onOff, bulbType, bulbWatt, bulbAmount)
        {
            RoomName = roomName;
        }

        public override string ToString()
        {
            return base.ToString() + " Name of the room : " + RoomName;
        }
    }
}
