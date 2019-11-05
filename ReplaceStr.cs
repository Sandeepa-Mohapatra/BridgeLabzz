using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class ReplaceStr
    {

       public void ReplaceS()
        {
            string str = "Hello <<UserName>> , How are you";
            Console.WriteLine("Enter the string to replace");
            string s = Console.ReadLine();
            Console.WriteLine(str.Replace("<<UserName>>", s));

        }
    }
}
