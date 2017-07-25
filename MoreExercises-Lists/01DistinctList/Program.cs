﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01DistinctList
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
