using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class WindChill
    {
        public void FindWindChill(int v,int t)
        {
            

            if (v > 3 && v < 120 && t < 50)
            {
                double v1 = Math.Pow(v, 0.16);
                double w = 35.74 + (0.6215 * t) + ((0.4275 * t) - 35.75) * v1;
                Console.WriteLine("Wind Chill is: " + w);
            }
            else
            {
                Console.WriteLine("invalid entry");
            }


        }
    }
}
