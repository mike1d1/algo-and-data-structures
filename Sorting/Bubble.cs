namespace Sorting
{
    class Bubble
    {
        public static void Bubblesort(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                for(int j = arr.Length-1; j>i; j--)
                {
                    if(arr[j] < arr[j-1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = temp;
                    }
                }
            }
        }

        // Another version of bubble sort
        public static void BubblesortEasy(int[] arr)
        {
            bool switched = false;
            do
            {
                switched = false;
                for(int i = 1; i<arr.Length; i++)
                {
                    if(arr[i-1] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i-1];
                        arr[i-1] = temp;
                        switched = true;
                    }
                }
            } while(switched);
        }

        // Yet another implementation of bubble sort
        public static void OptimizedBubbleSort(int[] arr)
        {
            bool switched = false;
            int n = arr.Length;
            do
            {
                switched = false;
                for(int i = 1; i<n; i++)
                {
                    if(arr[i-1] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i-1];
                        arr[i-1] = temp;
                        switched = true;
                    }
                }
                n--;
            } while(switched);
        }
    }
}
