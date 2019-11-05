using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Anagram
    {

        public void ChkAnagram()
        {
            //Taking the input from keyboard

            Console.WriteLine("Enter 1st string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter 2st string");
            string s1 = Console.ReadLine();

            //Converting the string to char Array
            

            char[] a = s.ToCharArray();
            char[] a1 = s.ToCharArray();
           
       
            //Sorting arrays

            Array.Sort(a);
            Array.Sort(a1);
            s = "";
            s1 = "";
            //Storing into string again
            for(int i=0;i<a.Length;i++)
            {
                s += a[i];
            }
            for (int i = 0; i < a1.Length; i++)
            {
                s1 += a1[i];
            }

            //Cheaking whether its a anagram or not 
            Console.WriteLine(s.Contains(s1));

            

        }
    }
}
