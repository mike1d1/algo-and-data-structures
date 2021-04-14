namespace Sorting
{
    class Quick 
    {
        // Interface for the HelpMergeSort method, adds indices for the first and last elements in array
        public static void Quicksort(int[] arr)
        {
            HelpQuicksort(arr, 0, arr.Length-1);
        }

        // Recursively calls Partition method for subarrays
        private static void HelpQuicksort(int[] arr, int firstIndex, int lastIndex)
        {
            if(firstIndex < lastIndex)
            {
                int p = Partition(arr, firstIndex, lastIndex);
                HelpQuicksort(arr, firstIndex, p-1);
                HelpQuicksort(arr, p+1, lastIndex);
            }
        }

        // Chooses pivot element (always the last element) and sorts smaller and greater elements based on it
        private static int Partition(int[] arr, int firstIndex, int lastIndex)
        {
            int pivot = arr[lastIndex];
            int i = firstIndex - 1;
            for(int j = firstIndex; j < lastIndex; j++)
            {
                if(arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
            arr[lastIndex] = arr[i+1];
            arr[i+1] = pivot;
            return i+1;
        }
    }
}
