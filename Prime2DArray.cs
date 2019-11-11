
/*************************************Prime no with 2DArray*********************************************/
/*Take a range of 0 - 1000 Numbers and find the Prime numbers in that range. Store
the prime numbers in a 2D Array, the first dimension represents the range 0-100,
100-200, and so on. While the second dimension represents the prime numbers in
that range
<<Author : Sandeepa Mohapatra>>
 */
/**********************************************************************************************/



using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Prime2DArray
    {
        int a1 = 0, a2 = 0, a3 = 0,a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0;
        public int[,] PrintArray()
        {
            Utility u = new Utility();
            int[,] ar = new int[10, 30];
            for (int j = 2; j <= 1000; j++)
            {
                if (u.ChkPrime(j))
                {
                    if (j > 0 && j < 100)
                    {
                        ar[0, a1] = j;
                        a1++;
                    }
                    else if (j > 101 && j < 200)
                    {
                        ar[1, a2] = j;
                        a2++;
                    }
                    else if (j > 201 && j < 300)
                    {
                        ar[2, a3] = j;
                        a3++;
                    }
                    else if (j > 301 && j < 400)
                    {
                        ar[3, a4] = j;
                        a4++;
                    }
                    else if (j > 401 && j < 500)
                    {
                        ar[4, a5] = j;
                        a5++;
                    }
                    else if (j > 501 && j < 600)
                    {
                        ar[5, a6] = j;
                        a6++;
                    }
                    else if (j > 601 && j < 700)
                    {
                        ar[6, a7] = j;
                        a7++;
                    }
                    else if (j > 701 && j < 800)
                    {
                        ar[7, a8] = j;
                        a8++;
                    }
                    else if (j > 801 && j < 900)
                    {
                        ar[8, a9] = j;
                        a9++;
                    }
                    else if (j > 901 && j < 1000)
                    {
                        ar[9, a10] = j;
                        a10++;
                    }
                }
                
            }

            return ar;
        }
       

    }
}
