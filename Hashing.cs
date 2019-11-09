using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Hashing
    {
        Node[] head = new Node[11];
        public void Hash(int data)
        {
            
            Node n = new Node();
            n.idata = data;
            n.next = null;
            
            int index = data % 11;
            
            if (head[index] == null)
            {
                head[index] = n;
            }
            else
            {
                Node temp = head[index];
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = n;
            }

            
        }
      public  void Display()
      { 
            for (int i = 0; i < head.Length; i++)
            {
                Node temp = head[i];
                if (temp != null)
                {
                    Console.Write("Remainder " + i + " : ");
                    while (temp != null)
                    {
                        Console.Write(temp.idata+" ");
                        temp = temp.next;
                    }
                }
                Console.WriteLine();
            }
      }

    }
}
