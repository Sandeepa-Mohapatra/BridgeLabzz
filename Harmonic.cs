using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Harmonic
    {
        public void ChkHarmonic()
        {
            Console.WriteLine("Enter the position");

            int n = int.Parse(Console.ReadLine());
            double h = 1.0;
            for (int i = 2; i <= n; i++)
            {
                h = h + (1.0 / i);
            }
            Console.WriteLine(h);
        }
    }
}
