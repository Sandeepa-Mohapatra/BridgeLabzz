using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class SqrtN
    {
        public void FindSqrt()
        {
            Console.WriteLine("Enter the no.");
            double c = double.Parse(Console.ReadLine());
            double Epsilon = 1E-15;   
            double t = c;
            
             
                while (Math.Abs(t - c / t) > Epsilon * t)
                {
                    t = (c / t + t) / 2.0;
                    

                }
            Console.WriteLine("Squre root of {0} is {1}",c,t);
           

            
            
        }
    }
}
