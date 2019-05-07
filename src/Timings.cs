using System;
using System.Collections.Generic;

namespace ChallengeSolution
{
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