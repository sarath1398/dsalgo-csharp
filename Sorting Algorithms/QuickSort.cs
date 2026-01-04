namespace Sorting_Algorithms
{
    internal class QuickSort
    {
        // Create a random pivot index to reduce choosing the highest
        // element or the lowest element in an sorted array all the time
        public static int GetPivot(int[] arr, int low, int high)
        {
            int randomValue = new Random().Next(low, high + 1);
            (arr[low], arr[randomValue]) = (arr[randomValue], arr[low]);
            return GetPartitionIndex(arr,low,high);
        }
        public static int GetPartitionIndex(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low;
            int j = high;

            while (i < j)
            {
                // Skips all the element that are lesser than the pivot element
                // from the left
                while (pivot >= arr[i] && i < high)
                {
                    i++;
                }
                // Skips all the element that are greater than the pivot element
                // to the right
                while (arr[j] > pivot && j > low)
                {
                    j--;
                }
                // Swap the greater than pivot element from the left
                // and the lesser than pivot element from the right
                // if the j'th index does not cross the i'th index
                if (i < j)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            // Swap the pivot with the lowest element
            // to place the pivot in the correct position
            (arr[low], arr[j]) = (arr[j], arr[low]);
            return j;
        }
        public static void QuickSortFunction(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pIndex = GetPivot(arr, low, high);
                // Repeat the process for arr[0..partitionIndex - 1] subarray
                QuickSortFunction(arr, low, pIndex - 1);
                // Repeat the process for arr[partitionIndex + 1..arr.Length - 1] subarray
                QuickSortFunction(arr, pIndex + 1, high);
            }
        }
    }
}
