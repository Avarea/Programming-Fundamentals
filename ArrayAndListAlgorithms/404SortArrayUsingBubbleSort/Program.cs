using System;
using System.Linq;

namespace _404SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            BubbleSort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void BubbleSort(int[] array)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        swapped = true;
                    }
                }
            }
        } 

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        } 

    }
}