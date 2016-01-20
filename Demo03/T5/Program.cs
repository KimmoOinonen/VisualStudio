/*
* Copyright (C) Kimmo Oinonen
*
* Homework project in Object-Oriented and GUI Programming.
* Program storage data of 5 students to array.
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
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[6];

            for (int i = 0; i <= 5; i++)
            {
                student[i] = new Student();
            }

            student[1].Name = "Kimmo Oinonen";
            student[1].ID = "K1744";
            student[1].Group = "TTV15S3";
            student[1].Age = 21;
            student[1].PrintData();
            
            student[2].Name = "Opiskelija 2";
            student[2].ID = "K1234";
            student[2].Group = "TTV15S3";
            student[2].Age = 19;
            student[2].PrintData();

            student[3].Name = "Opiskelija 3";
            student[3].ID = "K2345";
            student[3].Group = "TTV15S3";
            student[3].Age = 20;
            student[3].PrintData();

            student[4].Name = "Opiskelija 4";
            student[4].ID = "K3456";
            student[4].Group = "TTV15S3";
            student[4].Age = 22;
            student[4].PrintData();

            student[5].Name = "Opiskelija 5";
            student[5].ID = "K4567";
            student[5].Group = "TTV15S3";
            student[5].Age = 23;
            student[5].PrintData();

            Console.ReadLine();
        }
    }
}
