using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hours, minutes, seconds;
            Console.Write("Anna sekunnit : ");
            string rivi = Console.ReadLine();
            int.TryParse(rivi, out number);

            hours = number / 3600;
            minutes = (number - (hours * 3600)) / 60;
            seconds = (number - ((hours * 3600) + (minutes * 60)));
            
            Console.Write("Sekuntiaika voidaan ilmaista muodossa: ");
            Console.Write("\nTunnit " + hours);
            Console.Write("\nMinuutit " + minutes);
            Console.Write("\nSekunnit " + seconds);

            Console.ReadLine();
        }
    }
}
