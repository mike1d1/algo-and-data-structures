using System;

namespace Sorting
{
    class Program
    {
        // Generate random array of the given length and with values from 0 to and including upperBound
        public static int[] CreateRandomArray(int length, int upperBound = 100) 
        {
            if(length <= 1) 
            {
                throw new ArgumentException("Method RandomArray can only initialize an array with length greater than or equal 2");
            }
            if(upperBound < 1)
            {
                throw new ArgumentException("The argument upperBound should be at least 1");
            }
            Random rand = new Random();
            int[] arr = new int[length];
            int upper = upperBound + 1;
            for(int i = 0; i<length; i++) {
                arr[i] = rand.Next(upper);
            }
            return arr;
        }

        // Prints the given array to the console
        public static void PrintArray(int[] arr) 
        {
            foreach(int i in arr) 
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Before:");
            int[] arr = CreateRandomArray(10, 100);
            PrintArray(arr);
            Console.WriteLine("After:");
            Insertion.InsertionSort(arr);
            PrintArray(arr);
        }
    }
}
