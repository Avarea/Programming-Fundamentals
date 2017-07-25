using System;

namespace LargestElementInArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int largestElement = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] > largestElement)
                {
                    largestElement = numbers[i];
                }
            }
            Console.WriteLine(largestElement);
        }
    }
}
