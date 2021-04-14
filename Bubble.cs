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
    }
}
