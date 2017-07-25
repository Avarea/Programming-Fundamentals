using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            //. , : ; ( ) [ ] " ' \ / ! ? (space).
            string[] input = Console.ReadLine()?.
                ToLower().
                Split(new char[]{'.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '!', '?', ' '}
                ,StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length <5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", input));

        }
    }
}
