using System;
using System.Collections.Generic;

namespace _01LetterRepetition
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (counts.ContainsKey(character))
                {
                    counts[character]++;
                }
                else
                {
                    counts[character] = 1;
                }
            }

            foreach (var character in counts.Keys)
            {
                Console.WriteLine($"{character} -> {counts[character]}");
            }
        }
    }
}
