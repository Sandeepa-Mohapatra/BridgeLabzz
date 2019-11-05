using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class CuponNum
    {
        public void  Couponno()
        {
            Console.WriteLine("Enter how many numbers you want to generate");
            Random ran = new Random();
            int n = int.Parse(Console.ReadLine());
            int r = ran.Next();

            int[] a = new int[n];
            a[0] = r;
            for (int i = 1; i < n; i++)
            {
                int r1 = ran.Next();
                if (a[i] != r1)
                {
                    a[i] = r1;
                }
                else
                {
                    i--;
                }


            }
            Console.WriteLine("Cupon numbers are");
            char[] ch = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


            for (int i = 0; i < n; i++)
            {
                int random = ran.Next();
                StringBuilder sb = new StringBuilder();

                while (random > 0)
                {
                    sb.Append(ch[random % ch.Length]);
                    random /= ch.Length;
                }

                String couponCode = sb.ToString();
                Console.WriteLine(couponCode + a[i]);

            }

            Console.WriteLine("the no of distinct no are " + n);
        }
    }
}
