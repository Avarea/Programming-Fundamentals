using System;
using System.Collections.Generic;

namespace LetterRepetition
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            char[] combination = Console.ReadLine().ToCharArray();

            for (int i = 0; i < combination.Length; i++)
            {
                if (!letters.ContainsKey(combination[i]))
                {
                    letters.Add(combination[i], 0);
                }
                letters[combination[i]]++;
            }

            foreach (KeyValuePair<char, int> item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
