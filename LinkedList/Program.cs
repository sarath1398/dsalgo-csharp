using static LinkedList.Classes;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singly Linked List without a tail pointer");
            SinglyLinkedList list = new();
            list.InsertAtBeginning(1);
            list.InsertAtBeginning(2);
            list.InsertAtBeginning(3);
            list.InsertAtBeginning(4);
            list.PrintList();
            list.head = null;
            list.InsertAtEnd(1);
            list.InsertAtEnd(2);
            list.InsertAtEnd(3);
            list.InsertAtEnd(4);
            list.InsertAtPos(5, 1);
            list.PrintList();

            Console.WriteLine("Singly Linked List with a tail pointer");

            list.head = null;
            list.InsertAtBeginning(1,true);
            list.InsertAtBeginning(2,true);
            list.InsertAtBeginning(3,true);
            list.InsertAtBeginning(4,true);
            list.PrintList();
            list.head = null;
            list.InsertAtEnd(1,true);
            list.InsertAtEnd(2,true);
            list.InsertAtEnd(3,true);
            list.InsertAtEnd(4,true);
            list.InsertAtPos(5, 5, true);
            list.InsertAtEnd(6, true);
            list.PrintList();
        }
    }
}
