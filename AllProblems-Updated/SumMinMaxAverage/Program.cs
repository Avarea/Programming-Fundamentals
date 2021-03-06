﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
