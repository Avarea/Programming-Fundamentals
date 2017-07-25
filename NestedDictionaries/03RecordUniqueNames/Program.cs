using System;
using System.Collections.Generic;

namespace _03RecordUniqueNames
{
    class Program
    {
        static void Main()
        {
            HashSet<string> names = new HashSet<string>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputCount; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
