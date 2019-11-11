
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
        Node Front;
        Node Rear;

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
                    if (n.next.idata > data)
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
        //Stack Methods
        int top;
        char[] ch = new char[200];
        public void Push(char item)
        {
            ch[++top] = item;
        }
        public void Pop()
        {
            if (top <= 0)
                Console.WriteLine("Stack is empty");

            else
                top--;
            char i = ch[top];

        }
        public char Peek()
        {
            top--;
            char var = ch[top];
            top++;
            return var;
        }
        public Boolean IsEmpty()
        {
            if (top <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Size()
        {
            return top;
        }


        public void Enqueue(int data)
        {

            Node node = new Node();
            node.idata = data;
            node.next = null;
            if (Front == null && Rear == null)
            {
                Front = Rear = node;
            }
            else
            {
                Rear.next = node;
            }


        }
        public void ShowQ()
        {
            Node node = Front;
            while (node.next != null)
            {
                Console.WriteLine(node.idata);
                node = node.next;
            }
            Console.WriteLine(node.idata);
        }

        public void Dequeue()
        {
            if (Front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else if (Front.next != null)
            {
                Front = null;
            }
            else if (Front != null)
            {
                 
                Front = Front.next;
            }
           
        }
        public void addRear(char data)
        {
            Node node = new Node();
            node.cdata = data;
            node.next = null; 
            if (Front == null && Rear == null)
            {
                Front = Rear = node;
            }
            else
            {
                Rear.next = node;
                Rear = node;
            }
        }
        public int dsize()
        {
            int count = 0;
            Node temp = Front;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }
        public Char RevAndPrint()
        {
            Node temp = Front;
            char c;
            if (temp.next == null)
            {
                c = temp.cdata;
                temp = null;
                return c;
            }
            else
            {
                for(int i = 1; i < dsize()-1; i++)
                {
                    temp = temp.next;
                }
                    c = temp.next.cdata;
                    temp.next = null;
                Rear = temp;
            }

            return c ;
        }
        public int FindDay(int d, int m, int y)
        {
            if (d <= 31 && m <= 12)
            {
                double y0 = y - ((14 - m) / 12);
                double x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
                double m0 = m + 12 * ((14 - m) / 12) - 2;
                double d0 = (d + x + 31 * m0 / 12) % 7;
                int s = (int)Math.Round(d0) - 1;
                return s;
                
            }
            return -1;

        }
        public Boolean ChkPrime(int j)
        {
            
                int a = 0;
                for (int i = 1; i <= j; i++)
                {

                    if (j % i == 0)
                    {
                        a++;
                    }

                }
                if (a == 2)
                {
                return true;
                }

            return false;
            
        }

        public void Display(int[,] arr)
        {
            Console.WriteLine("Prime 2D array");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public static int CountBinaryTree(int numberOfElements)
        {


            int numerator = 0;
            int denominator = 0;

            ////to count no of binary trees for given no of elements
            numerator = Factorial(2 * numberOfElements);
            denominator = Factorial(numberOfElements + 1) * Factorial(numberOfElements);

            return numerator / denominator;


        }
        public static int Factorial(int no)
        {
            int f = no;
            while(no>1)
            {
                f = f * (no - 1);
                no--;

            }
            return f;
        }
        public static Boolean IsNum(String n)
        {
            for(int i=0;i<n.Length;i++)
            {
                if(char.IsDigit(n[i])==false)
                {
                    return false;
                }
            }
            return true;
        }
    }    
}

