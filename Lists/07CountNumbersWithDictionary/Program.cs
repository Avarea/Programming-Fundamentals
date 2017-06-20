using System;
using System.Collections.Generic;
using System.Linq;


namespace _07CountNumbersWithDictionary
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in input)
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
            foreach (var d in dict.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{d.Key} -> {d.Value}");
            }
        }
    }
}
