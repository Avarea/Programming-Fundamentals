using System;
using System.Collections.Generic;
using System.Linq;

namespace _07LargestNElement
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int integer = int.Parse(Console.ReadLine());
            numbers.Sort();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool inserted = false;
                for (int j = 0; j < result.Count; j++)
                {
                    if (numbers[i] < result[j])
                    {
                        result.Insert(j, numbers[i]);
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            List<int> largestNElements = new List<int>();

            for (int i = 0; i < integer; i++)
            {
                largestNElements.Add(result[i]);
            }




            Console.WriteLine(string.Join(" ", largestNElements));
        }
    }
}
