using System;
using System.Linq;

namespace ReverseArrayIn_place
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            int left = 0;
            int right = array.Length - 1;

            while (left <  right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
