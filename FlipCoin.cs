using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class FlipCoin
    {
        public void CoinFlip()
        {
            int count = 1;
            int a = 0, b = 0;
            int flip;
            Random r = new Random();
            while(count<=10)
            {
                flip = r.Next(2);
                Console.WriteLine(flip);
                if (flip ==0)
                {
                    Console.WriteLine("head");
                    a = a + 1;

                }
                else
                {
                    Console.WriteLine("tail");
                    b++;

                }
                count = count + 1;
            }
            Console.WriteLine("The percentage of head is " + a * 10 + "%");
            Console.WriteLine("The percentage of tail is " + b * 10 + "%");
        }
    }
}
