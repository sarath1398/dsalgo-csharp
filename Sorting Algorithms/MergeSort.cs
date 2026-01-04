namespace Sorting_Algorithms
{
    internal class MergeSort
    {
        public static void Merge(int[] arr, int low, int mid, int high)
        {
            int i = low; // Points to the subarray arr[low...mid]
            int j = mid+1; // Points to the subarray arr[mid+1...high]
            int k = 0; // Points to the temp array
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

            // Add the remaining elements to the temp array if exists
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            while (j <= high)
            {
                temp[k++] = arr[j++];
            }
            // Replace arr[low...high] with the values of temp
            for (int t = 0; t < temp.Length; t++)
            {
                arr[low + t] = temp[t];
            }
        }
        public static void MergeSortFunction(int[] arr, int low, int high)
        {
            // Base case : when recursion happens till only one element exists between arr[low..high]
            // i.e, Check whether the low and high are the same
            if (low >= high)
                return;
            int mid = (low + high) / 2;
            MergeSortFunction(arr, low, mid);
            MergeSortFunction(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }
    }
}
