using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Factors
    {
        public void FindFactors()
        {
            Console.WriteLine("Enter a no");

            int n = int.Parse(Console.ReadLine());

            while (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n /= 2;
            }


            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {

                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n /= i;
                }
            }


            if (n > 2)
                Console.WriteLine(n);
        
        }
    }
}
