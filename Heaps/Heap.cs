namespace Heaps
{
    // Constructing a min heap
    internal class Heap
    {
        public Heap(List<int> existingHeap)
        {
            heap = existingHeap;
            BuildHeap();
        }
        public List<int> heap = [];

        // helper functions
        public int GetParent(int index) => (index - 1) / 2;

        public int GetLeftChild(int index) => (2 * index) + 1;

        public int GetRightChild(int index) => (2 * index) + 2;

        public int Peek() => heap[0];

        public int Count() => heap.Count - 1;

        // heapify up - Should be done during push operation
        public void HeapifyUp()
        {
            int n = Count();
            int parent = GetParent(n);
            // swap till the parent is maintaining min heap order
            
            // added parent!=n condition since the only time a parent equals child
            // is when both are 0 after completing root element swap

            // never mind, n > 0 works as well since we swap till the child becomes actual root
            while (n > 0 && heap[parent] > heap[n])
            { 
                (heap[parent], heap[n]) = (heap[n], heap[parent]);
                // go to previous parent
                n = parent;
                parent = GetParent(n);
            }
        }

        // heapify down - Should be done during pop operation and build heap
        public void HeapifyDown(int index = 0) 
        {
            int n = Count();
            int s = index;
            while (GetLeftChild(s) <= n)
            {
                int l = GetLeftChild(s);
                int r = GetRightChild(s);
                int smallest = s;
                
                // find the smallest between left and right elements
                if (l <= n && heap[l] < heap[smallest])
                {
                    smallest = l;
                }

                if (r <= n && heap[r] < heap[smallest])
                {
                    smallest = r;
                }
                // Swap if root is not the smallest element
                if (heap[s] > heap[smallest])
                {
                    (heap[s], heap[smallest]) = (heap[smallest], heap[s]);
                    s = smallest;
                }

                // heap order is maintained already so exit.
                else
                {
                    break;
                }
            }
        }

        public int Pop()
        {
            int n = Count();
            if (n < 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }
            int value = Peek();
            // swap root with last element and remove last element
            (heap[0], heap[n]) = (heap[n], heap[0]);
            heap.RemoveAt(n);
            // heapify down from root
            if (n > 0)
            {
                HeapifyDown();
            }
            return value;
        }

        public void Push(int element)
        {
            heap.Add(element);
            HeapifyUp();
        }

        public void BuildHeap()
        {
            // Build heap for all non-leaf nodes
            int maxParent = GetParent(Count());
            while (maxParent >= 0)
            {
                HeapifyDown(maxParent);
                maxParent--;
            }
        }
    }
}
