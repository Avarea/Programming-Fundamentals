using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            int inputCount = int.Parse(Console.ReadLine());
            for (int cnt = 0; cnt < inputCount; cnt++)
            {
                string[] inputTokens = Console.ReadLine()?.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = inputTokens[0];
                string[] clothes = inputTokens[1].Split(',');

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }

                foreach (string cloth in clothes)
                {
                    Dictionary<string, int> clothDb = data[color];
                    if (!clothDb.ContainsKey(cloth))
                    {
                        clothDb.Add(cloth, 0);
                    }
                    clothDb[cloth]++;
                }
            }

            string[] searchTokens = Console.ReadLine()?.Split(' ');
            string searchedColor = searchTokens[0];
            string searchedCloth = searchTokens[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> colorData in data)
            {
                string color = colorData.Key;
                Dictionary<string, int> clothData = colorData.Value;

                Console.WriteLine("{0} clothes:", color);
                foreach (KeyValuePair<string, int> item in clothData)
                {
                    string cloth = item.Key;
                    int quantity = item.Value;

                    Console.Write("* {0} - {1}", cloth, quantity);

                    if (color == searchedColor && cloth == searchedCloth)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
