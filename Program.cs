using System;

namespace LinkedListProgram
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            NodeOperations nodeop = new NodeOperations();
            nodeop.Append(56);
            //nodeop.Append(30);
            nodeop.Append(70);
            nodeop.MidInsert(30);
            nodeop.Display();
        }
    }
}
