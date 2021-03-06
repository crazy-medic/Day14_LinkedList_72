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
        internal Node DeleteFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            Node temp = this.head;
            Console.WriteLine();
            Console.WriteLine("Deleted the head node : " + this.head.data);
            this.head = this.head.next;
            Console.WriteLine("The updated linked list is:");
            Display();
            return this.head;
        }
        internal Node DeleteLast()
        {
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                return null;
            }
            Node newnode = head;
            while(newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            Node temp = newnode.next;
            newnode.next = null;
            Console.WriteLine();
            Console.WriteLine("Deleted last node " + temp.data);
            Console.WriteLine("Updated list is");
            Display();
            return head;
        }
        internal Node SearchNode(int d)
        {
            while (this.head != null)
            {
                //int position = 1;
                if(this.head.data == d)
                {
                    //Console.WriteLine();
                    //Console.WriteLine("The element has been found at list position " + position + " for element " + d);
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
        internal Node InsertAfter(int d, int e)
        {
            Node temp0 = this.head;
            Node newNode = new Node(d);
            while(temp0 != null)
            {
                if (temp0.data == e)
                {
                    Node temp1 = temp0.next;
                    temp0.next = newNode;
                    newNode.next = temp1;
                    Console.WriteLine("\nInserted node " + newNode.data);
                }
                temp0 = temp0.next;
            }
            //Console.WriteLine();
            Display();
            return this.head;
        }
        internal Node DeleteSearched(int d)
        {
            // Store head node
            Node temp = head, prev = null;

            // If head node itself holds
            // the key to be deleted
            if (temp != null && temp.data == d)
            {
                // Changed head
                head = temp.next;
                return head;
            }

            // Search for the key to be
            // deleted, keep track of the
            // previous node as we need
            // to change temp.next
            while (temp != null && temp.data != d)
            {
                prev = temp;
                temp = temp.next;
            }
            // Unlink the node from linked list
            prev.next = temp.next;
            return head;
        }
        internal Node SortList()
        {
            Node current = head;
            Node index = null;
            Node temp = null;

            if (head == null)
            {
                return null;
            }
            else
            {
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.next;

                    while (index != null)
                    {
                        //If current node's data is greater than index's node data, swap the data between them  
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
    }
}
