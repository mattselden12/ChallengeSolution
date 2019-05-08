using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Buyer
    {
        public string name { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public Buyer(string bname, string bstreet, string bzip)
        {
            this.name = bname;
            this.street = bstreet;
            this.zip = bzip;
        }
    }
}