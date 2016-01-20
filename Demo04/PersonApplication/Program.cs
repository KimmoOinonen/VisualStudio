using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kimmo";
            person.LastName = "Oinonen";
            person.Address = "Minna Canthin katu";
            person.Age = 21;
            person.PhoneNumber = "0407298087";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Address = "Piippukatu 2";
            teacher.Age = 55;
            teacher.PhoneNumber = "0401234567";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Olli", "Opiskelija", "K1744");
            student.Age = 20;
            student.Address = "Koulukatu 10";
            student.PhoneNumber = "0409876543";
            Console.WriteLine(student.ToString());


            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
