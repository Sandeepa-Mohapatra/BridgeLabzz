using System;

namespace ConsoleApp2
{
   public class Array2D
    {
        //It will print the Integer Array
      public void ArrayInt(int r,int c)
        {
            
            int[,] a = new int[r, c];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The 2D array is :");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        //It will print the double Array

        public void ArrayDouble(int r, int c)
        {

            double[,] a = new double[r, c];
            Console.WriteLine("Enter the double elements");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] =Double.Parse( Console.ReadLine());
                }
            }
            Console.WriteLine("The 2D array is :");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        //It will print the boolean Array
        public void ArrayBoolean(int r,int c)
        {
            
            Boolean[,] a = new Boolean[r, c];
            
            Console.WriteLine("The 2D array is :");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        
    }
}
