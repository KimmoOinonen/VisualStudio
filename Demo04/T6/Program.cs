using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Shelf shelf = new Shelf("Bookshelf", 1, 5);
            Console.WriteLine(shelf.ToString());

            PaperBook paperbook = new PaperBook("Tekniikan maailma", "3", "2");
            paperbook.PaperOrBook = "Magazine";
            paperbook.PageNum = 70;
            Console.WriteLine(paperbook.ToString());

            Disc disc = new Disc("Movie", "10", "3");
            disc.DiscType = "Blu-ray";
            disc.Capacity = 50;
            Console.WriteLine(disc.ToString());

            Electronic electronic = new Electronic("Samsung", "1", "4");
            electronic.DeviceType = "Smartphone";
            electronic.DeviceScreen = 5.2;
            electronic.DeviceMemory = 32;
            electronic.DeviceOS = "Android";
            Console.WriteLine(electronic.ToString());

        }
    }
}
