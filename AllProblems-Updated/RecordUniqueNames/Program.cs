using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main()
        {
            HashSet<string> names = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < count; cnt++)
            {
                string name = Console.ReadLine();
                if (!names.Contains(name))
                {
                    names.Add(name);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
