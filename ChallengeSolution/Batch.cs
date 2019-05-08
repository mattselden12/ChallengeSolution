using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Batch
    {
        public string date { get; set; }
        public string type { get; set; }
        public List<Order> orders { get; set; }
        public Ender ender { get; set; }
        public Batch()
        {
            orders = new List<Order>();
        }
    }
}