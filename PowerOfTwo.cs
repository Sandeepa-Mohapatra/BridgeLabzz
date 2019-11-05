using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class PowerOfTwo
    {
        public void Powerof2()
        {
            Console.WriteLine("Enter a no");
            int N = int.Parse(Console.ReadLine());
            if (N >= 0 && N < 31)
            {
                Console.WriteLine("Power of 2 from 0 to N is :");
                for (int i = 0; i < N; i++)
                {
                    double p = Math.Pow(2, i);
                    
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}
