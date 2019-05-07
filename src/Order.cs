using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Order
    {
        public string date;
        public string code;
        public string number;
        public Buyer buyer;
        public List<Item> items = new List<Item>();
        public Timings timings;
        public Order(string orderdate, string ordercode, string ordernumber)
        {
            this.date = orderdate;
            this.code = ordercode;
            this.number = ordernumber;
        }
    }
}