using System;
using System.Collections.Generic;

namespace GroupContinentsCountriesAndCities
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            int inputCount = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCount; cnt++)
            {
                string[] inputTokens = Console.ReadLine()?.Split(' ');
                string continent = inputTokens[0];
                string country = inputTokens[1];
                string city = inputTokens[2];
                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new SortedSet<string>());
                }

                continentsData[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> item in continentsData)
            {
                string continent = item.Key;
                SortedDictionary<string, SortedSet<string>> countryData = item.Value;
                Console.WriteLine("{0}:", continent);

                foreach (KeyValuePair<string, SortedSet<string>> data in countryData)
                {
                    string country = data.Key;
                    SortedSet<string> city = data.Value;
                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", city));
                }
            }
        }
    }
}
