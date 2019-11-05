using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BinarySearchWord
    {
        public int BinarrySearch(String[] a, String x)
        {
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid = min + (max - 1) / 2;
                int r = x.CompareTo(a[mid]);
                if (r == 0)
                {
                    mid = mid + 1;
                    return mid;

                }
                else if (r > 0)
                {
                    min = mid + 1;


                }
                else
                {
                    r = mid - 1;
                }
            }
            return -1;

        }
    }
}
