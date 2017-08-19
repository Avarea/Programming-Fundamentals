using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main()
        {
            Dictionary<string,int> words = new Dictionary<string, int>();

            string[] wordsInput = Console.ReadLine()?.ToLower().Split(' ');
            for (int cnt = 0; cnt < wordsInput.Length; cnt++)
            {
                if (!words.ContainsKey(wordsInput[cnt]))
                {
                    words.Add(wordsInput[cnt], 0);
                }
                words[wordsInput[cnt]]++;
            }

            List<string> result = new List<string>();
            foreach (KeyValuePair<string, int> item in words)
            {
                if (item.Value % 2 == 1 )
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
