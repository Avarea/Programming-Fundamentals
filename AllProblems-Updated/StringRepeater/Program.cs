using System;

namespace StringRepeater
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, count));
        }

        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }
            return repeatedString;
        }
    }
}
