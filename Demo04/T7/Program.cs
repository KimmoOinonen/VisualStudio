using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Lights light1 = new Lights(true, "Led", 4, 3);
            Console.WriteLine(light1.ToString());

            Lights light2 = new Lights(false, "Halogen", 60, 2);
            Console.WriteLine(light2.ToString());

            Console.ReadLine();
        }
    }
}
