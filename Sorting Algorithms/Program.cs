namespace Sorting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectionSort.SelectionSortFunction([12, 2, 65, 34, 67, 54, 23, 86], 8);
            BubbleSort.BubbleSortFunction([12, 2, 65, 34, 67, 54, 23, 86], 8);
            InsertionSort.InsertionSortFunction([12, 2, 65, 34, 67, 54, 23, 86], 8);
        }
    }
}
