using System;
using System.Collections.Generic;
using System.Linq;

namespace _05SortArrayUsingInsertionSort
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>(input.Count);
            for (int i = 0; i < input.Count; i++)
            {
                bool inserted = false;
                for (int j = 0; j < result.Count; j++)
                {
                    if (input[i] < result[j])
                    {
                        result.Insert(j, input[i]);
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
