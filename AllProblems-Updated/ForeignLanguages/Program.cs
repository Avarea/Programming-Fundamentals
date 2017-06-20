using System;

namespace ForeignLanguages
{
    class Program
    {
        static void Main()
        {
            string country = Console.ReadLine();

            GetLanguage(country);
        }

        private static void GetLanguage(string country)
        {
            string result = string.Empty;
            if (country == "USA" || country == "England")
            {
                result = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                result = "Spanish";
            }
            else
            {
                result = "unknown";
            }
            Console.WriteLine(result);
        }
    }
}
