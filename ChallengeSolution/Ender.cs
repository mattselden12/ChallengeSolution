using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Ender
    {
        public int process { get; set; }
        public int paid { get; set; }
        public int created { get; set; }
        public Ender(int eprocess, int epaid, int ecreated)
        {
            this.process = eprocess;
            this.paid = epaid;
            this.created = ecreated;
        }
    }
}