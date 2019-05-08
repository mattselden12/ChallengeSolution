using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Order
    {
        public string date { get; set; }
        public string code { get; set; }
        public string number { get; set; }
        public Buyer buyer { get; set; }
        public List<Item> items { get; set; }
        public Timings timings { get; set; }
        public Order(string orderdate, string ordercode, string ordernumber)
        {
            items = new List<Item>();
            this.date = orderdate;
            this.code = ordercode;
            this.number = ordernumber;
        }
    }
}