﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _04SplitByWordCasing
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[]{ ' ', ';', ',', '.', ':', '!', '(', ')', '\'', '"', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase= new List<string>();
            List<string> mixedCase= new List<string>();
            List<string> upperCase= new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].All(char.IsUpper))
                {
                    upperCase.Add(input[i]);
                }
                else if (input[i].All(char.IsLower))
                {
                    lowerCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
