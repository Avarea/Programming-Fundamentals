using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            //. , : ; ( ) [ ] " ' \ / ! ? (space).
            List<string> input = Console.ReadLine()?
                .ToLower()
                .Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '!', '?', ' ', '\'',},
                    StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .OrderBy(x => x)
                .Where(x => x.Length < 5)
                .ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
