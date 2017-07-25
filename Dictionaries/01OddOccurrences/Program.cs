using System;
using System.Collections.Generic;

namespace _01OddOccurrences
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            string[] words = Console.ReadLine().ToLower().Split(' ');


            for (int i = 0; i < words.Length; i++)
            {

                    if (!counts.ContainsKey(words[i]))
                    {
                        counts.Add(words[i], 0);
                    }
                    else
                    {
                        counts[words[i]]++;
                    }
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> pair in counts)
            {
                if (pair.Value % 2 == 0)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
