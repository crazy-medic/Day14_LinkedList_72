using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    public class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
