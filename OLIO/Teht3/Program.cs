using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa, karvo, luku1, luku2, luku3;
            Console.Write("Anna kolme lukua : ");
            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());
            summa = luku1 + luku2 + luku3;
            karvo = summa / 3;
            
            Console.Write("Summa on " + summa);
            Console.Write("\nKeskiarvo on " + karvo);

            Console.ReadLine();
        }
    }
}
