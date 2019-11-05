using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Binary
    {
        public int SwapNibbles(int a)
        {

            return ((a & 0x0F) << 4 |(a & 0xF0) >> 4);
           // return a;
        }
    }
}
