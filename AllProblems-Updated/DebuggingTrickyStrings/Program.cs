using System;

namespace DebuggingTrickyStrings
{
    class Program
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            string currentString = string.Empty;

            for (int i = 1; i <= numberOfStrings; i++)
            {
                if (i < numberOfStrings)
                {
                    currentString = Console.ReadLine();
                    result += currentString + delimiter;
                }
                else
                {
                    currentString = Console.ReadLine();
                    result += currentString;
                }
            }
            Console.WriteLine(result);
        }
    }
}
