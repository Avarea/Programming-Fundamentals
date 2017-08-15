using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageCharacterDelimiter
{
    class Program
    {
        static void Main()
        {
            List<string> elements = Console.ReadLine()?.Split(' ').ToList();
            double totalSum = 0L;
            double counterCharacters = 0;
            for (int cnt = 0; cnt < elements.Count; cnt++)
            {
                string word = elements[cnt];
                counterCharacters += word.Length;
                for (int j = 0; j < word.Length; j++)
                {
                    totalSum += word[j];
                }
            }
            char charDelimeter = (char)((int)(totalSum / counterCharacters));
            string delimeter = "" + charDelimeter.ToString().ToUpper();

            Console.WriteLine(string.Join(delimeter, elements));
        }
    }
}
