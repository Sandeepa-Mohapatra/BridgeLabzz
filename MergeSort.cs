using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MergeSort
    {
        int[] arr;
        int[] temp;
        int length;
        public void Sort(int[] array)
        {
            arr = array;
            temp = new int[array.Length];
            length = array.Length;
            DivideArray(0, length-1);
        }
        public void DivideArray(int lowerindex,int higherindex)
        {
            if (lowerindex < higherindex)
            {
                int middle = lowerindex + (higherindex - lowerindex) / 2;
                DivideArray(lowerindex, middle);
                DivideArray(middle + 1, higherindex);
                Mergesort(lowerindex, middle, higherindex);

            }

        }
        public void Mergesort(int lowerindex,int middle,int higherindex)
        {
            if (lowerindex <= higherindex)
            {
                for (int l = lowerindex; l <= higherindex; l++)
                {
                    temp[l] = arr[l];
                }
                int i = lowerindex;
                int j = middle+1;
                int k = lowerindex;
                while (i <= middle && j <= higherindex)
                {
                    if (temp[i] <= temp[j])
                    {
                        arr[k] = temp[i];
                        i++;

                    }
                    else
                    {
                        arr[k] = temp[j];
                        j++;
                    }
                    k++;
                }
                while (i <= middle)
                {
                    arr[k] = temp[i];
                    k++;
                    i++;
                }
               /* for (int l = 0; l < arr.Length; l++)
                {
                    Console.WriteLine(arr[l]);
                }*/
            }
            /*for (int l = 0; l < arr.Length; l++)
            {
                Console.WriteLine(arr[l]);
            }*/
        }
    }
}
