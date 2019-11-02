using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSortWord
    {
        public String[] InsertionSort(String[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                String element = arr[i];
                int j;
                for (j = i - 1; j >= 0 && element.CompareTo(arr[j]) <= 0; j--)
                    arr[j + 1] = arr[j];

                arr[j + 1] = element;
            }
            return arr;

        }
    }
}
