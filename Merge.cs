namespace Sorting 
{
    class Merge 
    {
        // Interface for the HelpMergeSort method, adds needed arguments
        public static void MergeSort(int[] arr) 
        {
            HelpMergeSort(arr, 0, arr.Length-1);
        }

        // Recursively divides array in smaller parts and calls HelpMerge method
        private static void HelpMergeSort(int[] arr, int firstIndex, int lastIndex) 
        {
            if(firstIndex < lastIndex)
            {
                int middleIndex = firstIndex + (lastIndex - firstIndex)/2;
                HelpMergeSort(arr, firstIndex, middleIndex);
                HelpMergeSort(arr, middleIndex+1, lastIndex);
                HelpMerge(arr, firstIndex, middleIndex, lastIndex);
            }
        }

        // Merges two subarrays while sorting them
        private static void HelpMerge(int[] arr, int firstIndex, int middleIndex, int lastIndex) 
        {
            // Calculate the size of the two subarrays and create them 
            int n1 = middleIndex - firstIndex + 1;
            int n2 = lastIndex - middleIndex;
            int[] left = new int[n1];
            int[] right = new int[n2];

            // Copy values from initial array to subarrays 
            int i, j;
            for(i = 0; i < n1; i++) 
            {
                left[i] = arr[firstIndex+i];
            }
            for(j = 0; j < n2; j++) 
            {
                right[j] = arr[middleIndex + 1 + j];
            }

            // Merge two subarrays 
            i = 0;
            j = 0;
            int k = firstIndex;
            while(i < n1 && j < n2) 
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                } else 
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy remaining values to the initial array 
            // Only one of the loops will be entered 
            while(i < n1) 
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while(j < n2) 
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
