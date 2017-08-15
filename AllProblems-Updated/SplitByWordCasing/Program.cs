using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', ';', ',', '.', ':', '!', '(', ')', '\'', '"', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                if (input[cnt].All(char.IsUpper))
                {
                    upperCase.Add(input[cnt]);
                }
                else if (input[cnt].All(char.IsLower))
                {
                    lowerCase.Add(input[cnt]);
                }
                else
                {
                    mixedCase.Add(input[cnt]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
