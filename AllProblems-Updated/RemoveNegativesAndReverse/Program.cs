using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int cnt = 0; cnt < numbers.Count; cnt++)
            {
                if (numbers[cnt] > 0)
                {
                    result.Add(numbers[cnt]);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("empty");   
            }
            else
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
