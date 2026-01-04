namespace Sorting_Algorithms
{
    internal class MergeSort
    {
        public static void Merge(int[] arr, int low, int mid, int high)
        {
            int i = low;
            int j = mid+1;
            int k = 0;
            int[] temp = new int[high - low + 1];
            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            while (j <= high)
            {
                temp[k++] = arr[j++];
            }
            for (int t = 0; t < temp.Length; t++)
            {
                arr[low + t] = temp[t];
            }
        }
        public static void MergeSortFunction(int[] arr, int low, int high)
        {
            if (low >= high)
                return;
            int mid = (low + high) / 2;
            MergeSortFunction(arr, low, mid);
            MergeSortFunction(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }
    }
}
