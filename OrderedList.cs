/*************************************Ordered List*********************************************/
/*Read .a List of Numbers from a file and arrange it ascending Order in a
Linked List. Take user input for a number, if found then pop the number out of the
list else insert the number in appropriate position
<<Author : Sandeepa Mohapatra>>
 */
 /**********************************************************************************************/





using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
    class OrderedList
    {
       
        public void OperationOL()
        {
            //The object of Utility Class is created
             Utility u = new Utility();

            //This will fetch all texts from the text file
            String s1 = File.ReadAllText(@"C:\Users\COMPUTER\source\repos\ConsoleApp4\ConsoleApp4\TextFile2.txt");

            //This will simply print the text after fetching
            System.Console.WriteLine("Contents of TextFile2.txt = {0}", s1);

            //This will split the text and store that in a string array 
            String[] s2 = s1.Split();
            int count = 0;
            foreach (String i in s2)
            {

                Console.WriteLine(i);
                //This will count the no of element present in that array
                count++;

            }

            //Declaring an integer array ,Converting it to integer and storing it in an array
            int[] arr = new int[count];
            for(int i=0;i<count;i++)
            {
                arr[i] = int.Parse(s2[i]);
                
            }

            //This will sort the array and return the sorted array
            int[] arr1 = u.BubbleSortI(arr);
            
            //Insering Elements to the linked list
            foreach (int i in arr1)
            {

                u.InsertInt(i);

            }
            Console.WriteLine("Sorted LinkedList: ");
            //This will disply the value in linked list    
            u.ShowI();
            //Take a user input to search the element
            Console.WriteLine("Enter the element you want to search");
            int c = int.Parse(Console.ReadLine());
            int c1=u.SearchingInt(c);
            //If the element fpund then delet that
            if (c1 > 0)
            {
                u.deletAt(c1);

            }
            //If the element is not present then this will insert that in the currect place
            if (c1 == 0)
            {
                u.InsertAtPosition(c);
                File.AppendAllText(@"C:\Users\COMPUTER\source\repos\ConsoleApp4\ConsoleApp4\TextFile2.txt"," "+c.ToString());
            }

            //Display the final list
            Console.WriteLine("After mordifying , the elements are:");
            Console.WriteLine();
            u.ShowI();



        }
    }
}
