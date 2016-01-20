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
            return base.ToString() + " " + PaperOrBook + " " + PageNum;
        }
    }
}
