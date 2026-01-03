namespace Sorting_Algorithms
{
    public class BubbleSort
    {
        public static void BubbleSortFunction(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                // For every iteration, the maximum value moves to the last
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap consecutive elements based on minimum/maximum condition
                    if (arr[j] > arr[j+1])
                    {
                        (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(',',arr));
        }
    }
}
