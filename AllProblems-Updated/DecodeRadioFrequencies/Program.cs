using System;
using System.Collections.Generic;

namespace DecodeRadioFrequencies
{
    class Program
    {
        static void Main()
        {
            string[] frequenciesInput = Console.ReadLine()?.Split(' ');
            List<char> endMessage = new List<char>();
            for (int cntIndex = 0; cntIndex < frequenciesInput.Length; cntIndex++)
            {
                string[] tokens = frequenciesInput[cntIndex].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char) firstFreq;
                char secondLetter = (char) secondFreq;

                if (firstFreq != 0)
                {
                    endMessage.Insert(cntIndex, firstLetter);
                }
                if (secondFreq != 0)
                {
                    endMessage.Insert(endMessage.Count - 1 - cntIndex, secondLetter);
                }
            }
            endMessage.Reverse();
            Console.WriteLine(string.Join("", endMessage));

        }
    }
}
