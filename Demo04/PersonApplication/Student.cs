using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }

        public Student(string firstName, string lastName, string id) 
            :base(firstName, lastName)
        {
            StudentID = id;
        }

        public void StudentMethod()
        {
            Console.WriteLine("Student does something...");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
