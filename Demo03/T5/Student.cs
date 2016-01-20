/*
* Copyright (C) Kimmo Oinonen
*
* This is class program of homework project in Object-Oriented and GUI Programming.
* Projects's program storage data of 5 students to array.
*
* Created: 19.1.2016.
*
*/
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
        public string ID { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }

        // method prints students data
        public void PrintData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Student ID : " + ID);
            Console.WriteLine("Group ID : " + Group);
            Console.WriteLine("Age : " + Age);
        }

    }
}
