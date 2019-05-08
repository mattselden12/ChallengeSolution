using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Buyer
    {
        public string name;
        public string street;
        public string zip;
        public Buyer(string bname, string bstreet, string bzip)
        {
            this.name = bname;
            this.street = bstreet;
            this.zip = bzip;
        }
    }
}