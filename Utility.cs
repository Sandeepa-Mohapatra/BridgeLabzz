using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Utility
    {
        Node head;
        public void Insert(int share)
        {
                Node node = new Node();
                node.data = share;
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
        public void Show()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
    }
}
