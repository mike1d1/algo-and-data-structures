namespace Sorting
{
    class HeapSorter
    {
        public static void HeapSort(int[] arr)
        {
            Heap heap = new Heap(arr);
            heap.BuildMaxHeap();
            for(int i = arr.Length -1; i>0; i--)
            {
                // Swap arr[i] and arr[0]
                int temp = arr[i];
                arr[i] = arr[0];
                arr[0] = temp;
                heap.heapLenght--;
                // Restore max heap property, so that the largest element is again on top of heap
                heap.MaxHeapify(0);
            }
        }
    }

    // Implementation of heap data structure that helps to sort the array
    public class Heap 
    {
        public int[] data;
        public int heapLenght;

        public Heap(int[] data)
        {
            this.data = data;
        }

        public int Left(int i)
        {
            return i * 2 + 1;
        }

        public int Right(int i)
        {
            return i * 2 + 2;
        }

        // Max heap property for subtree beginning at index i
        public void MaxHeapify(int i)
        {
            int leftIndex = Left(i);
            int rightIndex = Right(i);
            int maxIndex;
            if(leftIndex < this.heapLenght && data[leftIndex]>data[i])
            {
                maxIndex = leftIndex;
            } else 
            {
                maxIndex = i;
            }
            if(rightIndex < this.heapLenght && data[rightIndex]>data[maxIndex])
            {
                maxIndex = rightIndex;
            }
            if(maxIndex != i)
            {
                // Swap elements at index i and maxIndex
                int temp = data[i];
                data[i] = data[maxIndex];
                data[maxIndex] = temp;
                // Recursively heapify the subtree
                MaxHeapify(maxIndex);
            }
        }

        // Makes heap with max heap property from an unsorted array
        public void BuildMaxHeap()
        {
            this.heapLenght = data.Length;
            for(int i = data.Length/2 - 1; i>=0; i--)
            {
                this.MaxHeapify(i);
            }
        }
    }
}
