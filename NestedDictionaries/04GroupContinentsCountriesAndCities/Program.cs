using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GroupContinentsCountriesAndCities
{
    class Program
    {
        static void Main(string[] args)
        {
            var continentData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }

                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent].Add(country, new SortedSet<string>());
                }
                continentData[continent][country].Add(city);
            }

            foreach (var data in continentData)
            {
                string continent = data.Key;
                SortedDictionary<string, SortedSet<string>> countries = data.Value;

                Console.WriteLine("{0}:", continent);

                foreach (var countryData in countries)
                {
                    string country = countryData.Key;
                    SortedSet<string> city = countryData.Value;
                    Console.WriteLine("   {0} -> {1}", country, string.Join(", ", city));
                }
            }
        }
    }
}
