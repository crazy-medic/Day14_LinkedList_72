using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class NodeOperations
    {
        internal Node head;
        internal void AddNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Node inserted as : " + data);
        }
        internal void Append(int d)
        {
            AddNode(d);
        }
    }
}
