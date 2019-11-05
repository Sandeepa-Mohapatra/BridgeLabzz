using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Utility
    {
        Node head;

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
                while(n.next!=null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            

        }
        public void Show()
        {
            Node node = head;
            while(node.next!=null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
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

        public void deletAt(int index)
        {
            if(index==0)
            {
                head = head.next;
            }
            else
            {
                Node n = head;
                Node n1 = null;
                for(int i=0;i<index-1;i++)
                {
                    n = n.next;
                }
                n1 = n.next;
                n.next = n1.next;
            }
        }
    }
}
