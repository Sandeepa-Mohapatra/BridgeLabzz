using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class TempratureConversion
    {
        public void Conversion(int n)
        {
            Console.WriteLine("if you want to convert Celsius to Fahrenheit then press 1 and fahrenheit to celsius press 2");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                int f = (n * 9 / 5) + 32;
                Console.WriteLine(f);
            }
            if (x == 2)
            {
                int c = n - 32 * (5 / 9);
                Console.WriteLine(c);
            }
        }
    }
}