using System;

namespace LinkedListProgram
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            NodeOperations nodeop = new NodeOperations();
            nodeop.Append(56);
            nodeop.Append(30);
            nodeop.Append(70);
            //nodeop.MidInsert(30);
            nodeop.Display();
            //nodeop.DeleteFirst();
            //nodeop.DeleteLast();
            //nodeop.SearchNode(30);
            nodeop.InsertAfter(40,30);
            Console.WriteLine("\nDeleted the node 40 ", nodeop.DeleteSearched(40));
            //Console.WriteLine();
            nodeop.Display();
        }
    }
}
