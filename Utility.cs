
/*************************************Utility*********************************************/
/*It contains All the methods which we use frequently to perform operations
<<Author : Sandeepa Mohapatra>>
 */
/**********************************************************************************************/



using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Utility
    {
        Node head;
    //This method will insert words to the linked list
        public void InsertString(String data)
        {

            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
         }
    //This method will insert numbers to the linked list
        public void InsertInt(int data)
        {

            Node node = new Node();
            node.idata = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }


        }
        //This method will insert numbers to the linked list in sorted position
        public void InsertAtPosition(int data)
        {

            Node node = new Node();
            node.idata = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    if(n.next.idata>data)
                    {
                        if (n.idata < data)
                        {
                            node.next = n.next;
                            n.next = node;

                            break;
                        }
                    }
                    n = n.next;
                }
                n.next = node;
            }
        }
        
        //This method will Disply words in linked list
        public void ShowS()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
        
        //This method will Disply numbers in linked list
        public void ShowI()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.idata);
                node = node.next;
            }
            Console.WriteLine(node.idata);
        }
        //This method will search word in linked list
        public int SearchingString(String item)
        {
            int count = 0;
            Node t = head;
            if (head.data == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (t.next != null)
                {
                    if (t.data == item)
                    {
                        Console.WriteLine("{0} is present", item);
                        Console.WriteLine();
                        return count;
                    }
                    t = t.next;
                    count++;
                }
            }
            Console.WriteLine("Your element is not in the list");

            return 0;
        }
        
        //This method will search number in linked list
        public int SearchingInt(int item)
        {
            
            Node t = head;
            int count = 0;
            if (head.idata == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (t.next != null)
                {
                    if (t.idata == item)
                    {
                        Console.WriteLine("{0} is present", item);
                        Console.WriteLine();
                        return count;
                    }
                    t = t.next;
                    count++;

                }
                
            }

            Console.WriteLine("Your element is not in the list");
            return 0;


        }
       
        
    //Delete node
        public void deletAt(int index)
        {
            if (index == 0)
            {
                head = head.next;
            }
            else
            {
                Node n = head;
                Node n1 = null;
                for (int i = 0; i < index - 1; i++)
                {
                    n = n.next;
                }
                n1 = n.next;
                n.next = n1.next;
            }
        }
     ////This method will sort the elements
        public int[] BubbleSortI(int[] a)
        {
            int temp;
            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            return a;
        }
    }
}
