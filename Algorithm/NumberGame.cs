using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class NumberGame
    {
        public void Game()
        {
            Console.WriteLine("Enter a no");
            int N =int.Parse(Console.ReadLine());
            double n = Math.Round(Math.Sqrt(N));
            Console.WriteLine(n);
            int[] a = new int[N];
            int count = 1;
            for(int i=0;i<N;i++)
            {
                a[i] = count;
                count++;
            }
            int l = 0;
            int u = a.Length-1;
            for(int i =0;i<n;i++)
            {
                int mid = (l + u) / 2;
                int num = a[mid];
                if (l<=u)
                {
                    if (num == a[mid])
                    {
                        Console.WriteLine("If your number is {0} enter 1",a[mid]);
                        Console.WriteLine("If your number is  greater than {0} enter 2", a[mid]);
                        Console.WriteLine("If your number is less than  {0} enter 3", a[mid]);
                        int var = int.Parse(Console.ReadLine());
                        if (var == 1)
                        {
                            Console.WriteLine("THANK YOU");
                            break;
                        }
                        if (var == 2)
                        {
                            l = mid;
                        }
                        if (var == 3)
                        {
                            u = mid;
                        }
                    }
                }
                
            }


        }

    }
        
}
