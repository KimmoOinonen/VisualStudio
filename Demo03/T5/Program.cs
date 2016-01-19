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
            student[1].Name = "Kimmo Oinonen";
            student[1].Number = "K1744";
            student[1].Gnumber = "TTV15S3";
            student[1].Age = 21;
            student[1].Listening = true;
            student[1].Working = true;
            
            student[2].Name = "Opiskelija 2";
            student[2].Number = "K1234";
            student[2].Gnumber = "TTV15S3";
            student[2].Age = 19;
            student[2].Listening = false;
            student[2].Working = false;
            
            student[3].Name = "Opiskelija 3";
            student[3].Number = "K2345";
            student[3].Gnumber = "TTV15S3";
            student[3].Age = 20;
            student[3].Listening = true;
            student[3].Working = false;

            student[4].Name = "Opiskelija 4";
            student[4].Number = "K3456";
            student[4].Gnumber = "TTV15S3";
            student[4].Age = 22;
            student[4].Listening = false;
            student[4].Working = true;

            student[5].Name = "Opiskelija 5";
            student[5].Number = "K4567";
            student[5].Gnumber = "TTV15S3";
            student[5].Age = 23;
            student[5].Listening = true;
            student[5].Working = true;

            for (int i = 0;i <= 5;i++)
            {
                //student[i].PrintData();
                Console.WriteLine(student[i]);
            }

            Console.ReadLine();
        }
    }
}
