using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Item
    {
        public string sku { get; set; }
        public int qty { get; set; }
        public Item(string isku, int iqty)
        {
            this.sku = isku;
            this.qty = iqty;
        }
    }
}