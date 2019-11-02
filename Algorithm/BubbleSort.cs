using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSort
    {
       public int[]  BubbleSortI(int[] a)
        {
            int temp;
            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            return a;
        }
    }
}
