using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                if (Math.Sqrt(input[cnt]) == (int)Math.Sqrt(input[cnt]))
                {
                    result.Add(input[cnt]);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
