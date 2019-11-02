using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Convertion
    {
        public int[] ToBinary()
        {
            Console.WriteLine("Enter the decimal no");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[10000];
            int i = 0;
            while (n > 0)
            {
                a[i] = n % 2;
                n = n / 2;
                i++;
            }
            for (int j = i - 1; j>=0;j--)
            {
                Console.Write(a[j]);
                Console.Write(" ");
            }
            return a;
        }
        public void ToDecimal()
        {
            Console.WriteLine("Enter the binary no");
            int b = int.Parse(Console.ReadLine());
            double d =0;
            int i = 0;
            int temp;
            while (b > 0)
            {
                temp= b % 10;
                d = d+ temp * Math.Pow(2, i);
                b = b / 10;
                i++;
            }
            Console.WriteLine("Decimal no is {0}",d); ;
        }
    }
}
