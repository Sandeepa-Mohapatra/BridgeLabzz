/*************************************Ordered List*********************************************/
/*construct an algorithm to
input a string of characters and check whether it is a palindrome.The solution to this problem will
use a deque to store the characters of the string. We will process the string from left to right and 
add each character to the rear of the deque.
<<Author : Sandeepa Mohapatra>>
 */
/**********************************************************************************************/

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
            //Taking user input
            Console.WriteLine("Enter the string to check");
            String s = Console.ReadLine();
            //adding the data to the queue
            for (int i = 0; i < s.Length; i++)
            {
                u.addRear(s[i]);
            }
            //storing the data  in a string after dequeue
            String s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                s1 += u.RevAndPrint();
            }
            //Checking pelindrome
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

