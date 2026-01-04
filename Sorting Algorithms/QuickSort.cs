namespace Sorting_Algorithms
{
    internal class QuickSort
    {
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
                while (pivot >= arr[i] && i < high)
                {
                    i++;
                }
                while (arr[j] > pivot && j > low)
                {
                    j--;
                }
                if (i < j)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[low], arr[j]) = (arr[j], arr[low]);
            return j;
        }
        public static void QuickSortFunction(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pIndex = GetPivot(arr, low, high);
                QuickSortFunction(arr, low, pIndex - 1);
                QuickSortFunction(arr, pIndex + 1, high);
            }
        }
    }
}
