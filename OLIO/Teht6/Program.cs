using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance;
            double consumption, price;
            Console.Write("Anna kuljettu matka : ");
            string rivi = Console.ReadLine();
            int.TryParse(rivi, out distance);

            consumption = (7.02 / 100) * distance;
            price = consumption * 1.595;

            Console.Write("Bensaa kuluu {0:F2} litraa,", consumption);
            Console.Write(" kustannukset ovat {0:F2} euroa", price);

            Console.ReadLine();
        }
    }
}
