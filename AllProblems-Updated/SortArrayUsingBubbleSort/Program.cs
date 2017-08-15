using System;
using System.Linq;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            BubbleSort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }


        static void BubbleSort(int[] arr)
        {
            while (true)
            {
                bool swapped = false;
                for (int cnt = 0; cnt < arr.Length - 1; cnt++)
                {
                    if (arr[cnt] > arr[cnt + 1])
                    {
                        Swap(ref arr[cnt], ref arr[cnt + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
