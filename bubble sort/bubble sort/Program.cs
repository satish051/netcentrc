using System;

namespace BubbleSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input: Array of integers
            Console.WriteLine("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine($"Enter {n} elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Perform Bubble Sort
            BubbleSort(array);

            // Output: Sorted Array
            Console.WriteLine("Sorted Array:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;

            // Outer loop for passes
            for (int i = 0; i < n - 1; i++)
            {
                // Inner loop for comparisons
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the elements are out of order
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
