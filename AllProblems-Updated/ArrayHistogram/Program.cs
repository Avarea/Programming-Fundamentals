using System;
using System.Collections.Generic;

namespace ArrayHistogram
{
    class Program
    {
        static void Main()
        {
            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            string[] inputStrings = Console.ReadLine()?.Split(' ');

            for (int cnt = 0; cnt < inputStrings.Length; cnt++)
            {
                if (!words.Contains(inputStrings[cnt]))
                {
                    words.Add(inputStrings[cnt]);
                    counts.Add(1);
                }
                else
                {
                    int index = words.IndexOf(inputStrings[cnt]);
                    counts[index]++;
                }
            }

            for (int firstUnsoreted = 0; firstUnsoreted < counts.Count - 1; firstUnsoreted++)
            {
                var i = firstUnsoreted + 1;
                while (i > 0)
                {
                    if (counts[i - 1] < counts[i])
                    {
                        int tempCount = counts[i];
                        counts[i] = counts[i - 1];
                        counts[i - 1] = tempCount;

                        string tempWord = words[i];
                        words[i] = words[i - 1];
                        words[i - 1] = tempWord;
                    }
                    i--;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", words[i], counts[i], ((double)counts[i] / (double)inputStrings.Length) * 100);
            }
        }
    }
}
