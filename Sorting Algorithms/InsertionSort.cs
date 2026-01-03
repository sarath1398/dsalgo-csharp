namespace Sorting_Algorithms
{
    internal class InsertionSort
    {
        public static void InsertionSortFunction(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int j = i;
                // Swap till arr[0...j] is in sorted order for each iteration
                // Check j > 0 since arr[j - 1] can lead to runtime errors for j = 0
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                    j--;
                }
            }
            Console.WriteLine(String.Join(',', arr));
        }
    }
}
