namespace LinkedList
{
    internal class Classes
    {
        public class ListNode(int val = 0, ListNode? next = null)
        {
            public int val = val;
            public ListNode? next = next;
        }

        // NOTE : the hasTail parameter exists just for learning purposes only
        // It is assumed that the state of hasTail will either be true or false
        // throughout runtime and not a mix of both
        public class SinglyLinkedList
        {
            public ListNode? head = null;
            public ListNode? tail = null;

            public void InsertAtBeginning(int value,bool hasTail = false)
            {
                ListNode? newNode = new(value, null);

                if (head == null && hasTail)
                {
                    head = newNode;
                    tail = newNode;
                }
                else if (head == null && !hasTail)
                {
                    head = newNode;
                }
                else
                {
                    newNode.next = head;
                    head = newNode;
                }
            }

            public void InsertAtEnd(int value, bool hasTail = false)
            {
                ListNode? newNode = new(value, null);

                if (head == null && hasTail)
                {
                    head = newNode;
                    tail = newNode;
                }
                else if (head == null && !hasTail)
                {
                    head = newNode;
                }
                else
                {
                    if (hasTail)
                    {
                        // O(1) operation
                        tail?.next = newNode;
                        tail = newNode;
                    }
                    else
                    {
                        // Takes O(n) without tail
                        ListNode? ptr = head;
                        while (ptr?.next != null)
                        {
                            ptr = ptr.next;
                        }
                        ptr?.next = newNode;
                    }
                }              
            }

            public void InsertAtPos(int value, int pos, bool hasTail = false)
            {
                ListNode newNode = new(value);

                // using a dummy node for handling 1-indexing complexities
                ListNode? dummy = new(0, head);
                ListNode? prev = dummy;

                for (int i = 0; i < pos - 1 && prev != null; i++)
                {
                    prev = prev?.next;
                }

                if (prev == null) return;

                newNode.next = prev.next;
                prev.next = newNode;

                head = dummy.next;
                if (newNode.next == null && hasTail)
                {
                    tail = newNode;
                }
            }

            public void PrintList()
            {
                ListNode? cur = head;
                while (cur != null)
                {
                    Console.Write(cur.val + " -> ");
                    cur = cur.next;
                }
                Console.Write("NULL \n");
            }
        }
    }
}
