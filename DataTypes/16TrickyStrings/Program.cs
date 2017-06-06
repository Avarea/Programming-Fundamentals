using System;

namespace _16TrickyStrings
{
    class Program
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int input = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 1; i <= input; i++)
            {
                string words = Console.ReadLine();
                result += words;
                if (i < input)
                {
                    result += delimiter;
                }

            }
            result.TrimEnd();
            Console.WriteLine(result.TrimEnd());
        }
    }
}
