using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Shelf
    {
        public string ItemName { get; set; }
        public int ItemAmount { get; set; }
        public int ShelfNum { get; set; }

        public Shelf(string itemName, int itemAmount, int shelfNum);
        {
            ItemName = itemName;
            ItemAmount = itemAmount;
            ShelfNum = shelfNum;
        }

        public override string ToString()
        {
            return ItemName + " " + ItemAmount + " " + ShelfNum;
        }
    }
}
