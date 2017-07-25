using System;
using System.Collections.Generic;

namespace _02CitiesByContinentAndCountry
{
    class Program
    {
        static void Main()
        {
            var continentData = new Dictionary<string, Dictionary<string, List<string>>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent].Add(country, new List<string>());
                }
                continentData[continent][country].Add(city);
            }

            foreach (var data in continentData)
            {
                string continent = data.Key;
                Dictionary<string, List<string>> countries = data.Value;

                Console.WriteLine("{0}:", continent);

                foreach (var countryData in countries)
                {
                    string country = countryData.Key;
                    List<string> city = countryData.Value;
                    Console.WriteLine("   {0} -> {1}", country, string.Join(", ", city));
                }
            }
        }
    }
}
