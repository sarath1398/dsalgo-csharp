namespace Sorting_Algorithms
{
    public class SelectionSort
    {
        public static void SelectionSortFunction(int[] arr, int n)
        {
            // The last element is always the min/max value
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
            Console.WriteLine(String.Join(',', arr));
        }
    }
}