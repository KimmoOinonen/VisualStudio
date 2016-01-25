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
    class PaperBook : Shelf
    {
        public string PaperOrBook { get; set; }
        public int PageNum { get; set; }

        public PaperBook(string itemName, int itemAmount, int shelfNum, string paperOrBook, int pageNum) 
            :base(itemName, itemAmount, shelfNum)
        {
            PaperOrBook = paperOrBook;
            PageNum = pageNum;
        }

        public override string ToString()
        {
            return base.ToString() + " Item type : " + PaperOrBook + " Number of pages : " + PageNum;
        }
    }
}
