namespace Heaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [4,12,3,5,1,8,9,2,7,6];
            Heap heap = new(list);
            heap.Push(-2);
            heap.Push(100);
            heap.Push(0);
            while(heap.Count() > 0)
            {
                Console.Write(heap.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
