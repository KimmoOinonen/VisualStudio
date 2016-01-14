using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikäsi : ");
            string rivi = Console.ReadLine();
            int luku;
            int.TryParse(rivi, out luku);

            if (luku < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (luku >= 18 && luku <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else if (luku > 65)
            {
                Console.WriteLine("Seniori");
            }

            Console.ReadLine();
        }
    }
}
