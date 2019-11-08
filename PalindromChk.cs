using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromChk
    {
        public void Check()
        {
            Utility u = new Utility();
            Console.WriteLine("Enter the string to check");
            String s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                u.addRear(s[i]);
            }
            String s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                s1 += u.RevAndPrint();
            }
            if (s == s1)
            {
                Console.WriteLine("Given string is a polindriome");
            }
            else
            {
                Console.WriteLine("Given string is not a polindriome");
            }
        }
    }
}

