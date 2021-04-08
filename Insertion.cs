namespace Sorting 
{
    class Insertion 
    {
        // Sorts the given array using insertion sort algorithm
        public static void InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++) 
            {
                int key = arr[i];
                int j = i-1;
                while(j >= 0 && key < arr[j]) 
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
        }
    }
}