using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
    public class Timings
    {
        public int start { get; set; }
        public int stop { get; set; }
        public int gap { get; set; }
        public int offset { get; set; }
        public int pause { get; set; }
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