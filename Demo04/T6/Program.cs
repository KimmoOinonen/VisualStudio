/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 22.1.2016
 * Author: Kimmo Oinonen
 */
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

            PaperBook paperbook = new PaperBook("Tekniikan maailma", 3, 2, "Magazine", 70);
            Console.WriteLine(paperbook.ToString());

            PaperBook paperbook2 = new PaperBook("Aapinen", 1, 2, "Book", 100);
            Console.WriteLine(paperbook2.ToString());

            Disc disc = new Disc("Movie", 10, 3, "Blu-ray", 50);
            Console.WriteLine(disc.ToString());

            Electronic electronic = new Electronic("Samsung", 1, 4, "Smartphone", 5.2, 32, "Android");
            Console.WriteLine(electronic.ToString());

            Console.ReadLine();

        }
    }
}
