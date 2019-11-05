using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Utility
    {
        double h1, min1, h2, min2, sec1, sec2;
        
       public void Start()
        {


            DateTime t1 = DateTime.Now;
            h1 = t1.Hour;
            min1 = t1.Minute;
            sec1 = t1.Second;
            

        }
       public void Stop()
        {
            DateTime t2 = DateTime.Now;
            h2 = t2.Hour;
            min2 = t2.Minute;
            sec2 = t2.Second;
            Console.WriteLine("difference");
            Console.WriteLine("{0},{1},{2}", (h2 - h1), (min2 - min1), (sec2 - sec1));
        }
        public int BinarrySearchInt(int[] a,int x)
        {
            Start();
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (x == a[mid])
                {
                    mid=mid+1;
                    return mid;
                    
                }
                else if (x < a[mid])
                {
                    max = mid - 1;

                }
                else
                {
                    min = mid + 1;
                }
            }

            
            Stop();
            return -1;

        }
        public int BinarrySearchString(String[] a, String x)
        {
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid = min + (max-1) / 2;
                int r = x.CompareTo(a[mid]);
                if (r==0)
                {
                    mid = mid + 1;
                    return mid;

                }
                else if (r>0)
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
        public int[] InsertionSortInt(int[] ar)
        {
            
                for (int i = 0; i < ar.Length - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (ar[j - 1] > ar[j])
                        {
                            int t = ar[j - 1];
                            ar[j - 1] = ar[j];
                            ar[j] = t;
                        }
                    }
                }
                return ar;
            
        }
        public String[] InsertionSortString(String[] arr)
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
        public void BubbleSortInt()
        {

        }
        public void BubbleSortString()
        {

        }
    }
}
