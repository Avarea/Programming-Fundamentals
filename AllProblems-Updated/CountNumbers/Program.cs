using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers_List
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            numbers.Add(int.MaxValue);
            numbers.Sort();

            int count = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    count = 1;
                }
            }
        }
    }
}
