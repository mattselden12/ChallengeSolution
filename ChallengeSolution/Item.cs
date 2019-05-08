using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Item
    {
        public string sku;
        public int qty;
        public Item(string isku, int iqty)
        {
            this.sku = isku;
            this.qty = iqty;
        }
    }
}