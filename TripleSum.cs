using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class TripleSum
    {
      public void ThreeSum()
        {

            Console.WriteLine("enter number of elements");

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("enter elements");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Boolean found = true;
            Console.WriteLine("The suquence are:");
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.Write(arr[i]+" ");
                            
                            Console.Write(arr[j]+" ");
                            
                            Console.Write(arr[k]+" ");
                            Console.WriteLine();
                            
                            found = true;
                        }
                    }
                }
            }

            // If no triplet with 0 sum found in array 
            if (found == false)
                Console.WriteLine(" not exist ");
        }

    }
}
