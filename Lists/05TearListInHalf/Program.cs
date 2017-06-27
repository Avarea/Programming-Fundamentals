using System;
using System.Collections.Generic;
using System.Linq;

namespace _05TearListInHalf
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> upper = new List<int>();
            List<int> lower = new List<int>();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count / 2 > i)
                {
                    lower.Add(numbers[i]);
                }
                else
                {
                    upper.Add(numbers[i]);
                }
            }

            for (int i = 0; i < upper.Count; i++)
            {
                result.Add(upper[i] / 10);
                result.Add(lower[i]);
                result.Add(upper[i] % 10);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
