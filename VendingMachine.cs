using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class VendingMachine
    {
        public void CountNote()
        {
            int[] arr = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            Console.WriteLine("Enter the amount");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 7; i++)
            {
                if (arr[i] <= n)
                {
                    int a = n / arr[i];
                    Console.WriteLine("The no of {0} Rs note is {1}", arr[i], a);
                    n = n - arr[i] * a;

                }
            }
        }
    }
}

