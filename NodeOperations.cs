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
        internal void MidInsert(int d)
        {
            {
                Node new_node = new Node(d);
                Node pos = head;
                int len = 0;
                while (pos != null)
                {
                    len++;
                    pos = pos.next;
                }
                int count = ((len % 2) == 0) ? (len / 2) : (len + 1) / 2;
                pos = head;
                while (count-- > 1)
                {
                    pos = pos.next;
                }
                new_node.next = pos.next;
                pos.next = new_node;
            }
            Console.WriteLine("Mid Inserted element " + d);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty!");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
