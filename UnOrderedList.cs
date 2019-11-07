
/*************************************Ordered List*********************************************/
/*Read the Text from a file, split it into words and arrange it as Linked List.
Take a user input to search a Word in the List. If the Word is not found then add it
to the list, and if it found then remove the word from the List. In the end save the
list into a file.

<<Author : Sandeepa Mohapatra>>
 */
/**********************************************************************************************/


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
            //Object Created
            Utility u = new Utility();
            //This will fetch the content of the text file and store it to a string 
            String s = File.ReadAllText(@"C:\Users\COMPUTER\source\repos\ConsoleApp4\ConsoleApp4\TextFile1.txt");
            //This will just display 
            System.Console.WriteLine("Contents of TextFile1.txt = {0}", s);
            //This will Split the String and store it to a string array
            string[] s1 = s.Split();
            //This will insert the words in linked list
            foreach (String i in s1)
            {
                u.InsertString(i);

            }
            //Display
            Console.WriteLine("After inserting, the elements are:");
            Console.WriteLine();
            u.ShowS();
            Console.WriteLine();
            Console.WriteLine("Enter the string which you want to search");
            Console.WriteLine();
            //It will take the user input to search the word
            String s2 = Console.ReadLine();
            int b = u.SearchingString(s2);
            //If found than delet
            if (b > 0)
            {
                u.deletAt(b);

            }
            //If not found than insert
            if (b == 0)
            {
                u.InsertString(s2);
                File.AppendAllText(@"C:\Users\COMPUTER\source\repos\ConsoleApp4\ConsoleApp4\TextFile1.txt"," "+s2);
            }//Display
            Console.WriteLine("After mordifying , the elements are:");
            Console.WriteLine();
            u.ShowS();

        }
    }
}
