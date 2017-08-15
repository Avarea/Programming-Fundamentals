using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers_Dictionary
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in input)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] += 1;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (KeyValuePair<int, int> d in dict.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{d.Key} -> {d.Value}");
            }
        }
    }
}
