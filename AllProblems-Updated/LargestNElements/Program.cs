using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNElements
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            int stop = int.Parse(Console.ReadLine());
            list.Sort();

            while (stop < list.Count)
            {
                list.Remove(list[0]);
            }
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
