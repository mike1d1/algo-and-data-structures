namespace Sorting 
{
    class Insertion 
    {
        // Sorts the given array using insertion sort algorithm
        public static void InsertionSort(int[] arr)
        {
            // Start loop from the 2nd element 
            for(int i = 1; i < arr.Length; i++) 
            {
                // Copy the current element 
                int key = arr[i];
                int j = i-1;
                
                // Compare current element to every previous element and swap if current is smaller
                while(j >= 0 && key < arr[j]) 
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Put current element at the right place
                arr[j+1] = key;
            }
        }
    }
}
