using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace DataStructure
{
    class UnOrderedList
    {
        public void Operation()
             
        {
            Utility u = new Utility();
            String s = File.ReadAllText(@"C:\Users\COMPUTER\source\repos\ConsoleApp4\ConsoleApp4\TextFile1.txt");
                System.Console.WriteLine("Contents of TextFile1.txt = {0}", s);
            string[] s1 = s.Split();
             foreach(String i in s1)
             {
                 u.InsertString(i);
                 
             }
            Console.WriteLine("After inserting, the elements are:");
            Console.WriteLine();
            u.Show();
            Console.WriteLine();
            Console.WriteLine("Enter the string which you want to search");
            Console.WriteLine();
            String s2 = Console.ReadLine();
           int b=u.SearchingString(s2);
            if(b>0)
            {
                u.deletAt(b);
            }
            if(b==0)
            {
                u.InsertString(s2);
            }
            Console.WriteLine("After deleting, the elements are:");
            Console.WriteLine();
            u.Show();

        }
    }
}
