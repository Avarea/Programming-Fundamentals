using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main()
        {
            Dictionary<string,Dictionary<string, List<string>>> continentsData = new Dictionary<string,Dictionary<string,List<string>>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCount; cnt++)
            {
                string[] inputTokens = Console.ReadLine()?.Split(' ');
                string continent = inputTokens[0];
                string country = inputTokens[1];
                string city = inputTokens[2];
                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new List<string>());
                }

                continentsData[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> item in continentsData)
            {
                string continent = item.Key;
                Dictionary<string, List<string>> countryData = item.Value;
                Console.WriteLine("{0}:", continent);

                foreach (KeyValuePair<string, List<string>> data in countryData)
                {
                    string country = data.Key;
                    List<string> city = data.Value;
                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", city));
                }
            }
        }
    }
}
