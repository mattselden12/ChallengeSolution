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
        public Order ActiveOrder;
    }
    public class Ender
    {
        public int process;
        public int paid;
        public int created;
        public Ender(int eprocess, int epaid, int ecreated){
            this.process = eprocess;
            this.paid = epaid;
            this.created = ecreated;
        }
    }
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
    public class Timings
    {
        public int start;
        public int stop;
        public int gap;
        public int offset;
        public int pause;
        public Timings(int tstart, int tstop, int tgap, int toffset, int tpause)
        {
            this.start = tstart;
            this.stop = tstop;
            this.gap = tgap;
            this.offset = toffset;
            this.pause = tpause;
        }
    }
}