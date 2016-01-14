using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna oppilaan pistemäärä : ");
            string rivi = Console.ReadLine();
            int luku;
            int.TryParse(rivi, out luku);

            if (luku == 0 || luku == 1)
            {
                Console.WriteLine("Numero on 0");
            }
            else if (luku == 2 || luku == 3)
            {
                Console.WriteLine("Numero on 1");
            }
            else if (luku == 4 || luku == 5)
            {
                Console.WriteLine("Numero on 2");
            }
            else if (luku == 6 || luku == 7)
            {
                Console.WriteLine("Numero on 3");
            }
            else if (luku == 8 || luku == 9)
            {
                Console.WriteLine("Numero on 4");
            }
            else if (luku == 10 || luku == 11 || luku == 12)
            {
                Console.WriteLine("Numero on 5");
            }
            else if (luku < 0 || luku > 12)
            {
                Console.WriteLine("Et antanut oikeaa numeroa");
            }

            Console.ReadLine();
        }
    }
}
