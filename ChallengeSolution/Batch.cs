using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Batch
    {
        public string date;
        public string type;
        public List<Order> orders = new List<Order>();
        public Ender ender;
    }
}