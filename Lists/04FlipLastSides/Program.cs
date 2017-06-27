using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FlipLastSides
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[(numbers.Count - 1) - i];
                numbers[(numbers.Count - 1) - i] = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
