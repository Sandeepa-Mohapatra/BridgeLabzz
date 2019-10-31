using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
   public class Prime
    {

        public void ChkPrime()
        {
            int count = 0;
            Console.WriteLine("Prime nos are:");
            for (int j = 2; j <= 1000; j++)
            {
                int a = 0;
                for (int i = 1; i <= j; i++)
                {
                    
                    if (j % i == 0)
                    {
                        a++;
                    }
                    
                }
                if(a==2)
                {
                    Console.WriteLine(j);
                    count++;
                }
            }
            Console.WriteLine("There are {0} nos in between 1 and 1000",count);
        }
    }
}
