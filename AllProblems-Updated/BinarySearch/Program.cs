using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            int numberToFind = int.Parse(Console.ReadLine());
            int countLinearSearch = LinearSearch(numbers, numberToFind);
            int countBinarySearch = BinarySearch(numbers, numberToFind);
            numbers.Sort();

            if (numbers.Contains(numberToFind))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Linear search made {countLinearSearch} iterations");
            Console.WriteLine($"Binary search made {countBinarySearch} iterations");
        }

        private static int BinarySearch(List<int> numbers, int numberToFind)
        {
            numbers.Sort();
            int count = 0;
            int min = 0;
            int max = numbers.Count - 1;

            while (min <= max)
            {
                int midPoint = (min + max) / 2;
                count++;
                if (numbers[midPoint] < numberToFind)
                {
                    min = midPoint + 1;
                }
                if (numbers[midPoint] > numberToFind)
                {
                    max = midPoint - 1;
                }
                if (numbers[midPoint] == numberToFind)
                {
                    break;
                }
            }
            return count;
        }

        private static int LinearSearch(List<int> numbers, int numberToFind)
        {
            int count = 0;

            for (int cnt = 0; cnt < numbers.Count; cnt++)
            {
                count++;
                if (numbers[cnt] == numberToFind)
                {
                    return count;
                }
            }
            return count;
        }
    }
}
