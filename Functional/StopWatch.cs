using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class StopWatch
    {
        double h1, min1,h2,min2,h,m,sec1,sec2;
        public void Start()
        {

           
            DateTime t1 = DateTime.Now;
            h1 = t1.Hour;
            min1 = t1.Minute;
            sec1 = t1.Second;
          
           
        }
        public void Stop()
        {
            DateTime t2 = DateTime.Now;
            h2 = t2.Hour;
            min2 = t2.Minute;
            sec2 = t2.Second;
            Console.WriteLine("difference");
            Console.WriteLine("The Elaps time is {0}hr {1}min {2}sec", (h2 - h1), (min2 - min1), (sec2 - sec1));
        }
        


    }
}
