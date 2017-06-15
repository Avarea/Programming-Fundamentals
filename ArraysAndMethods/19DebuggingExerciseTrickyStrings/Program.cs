using System;


namespace _19DebuggingExerciseTrickyStrings
{
    class Program
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());

            var currentString = string.Empty;
            var result = string.Empty;

            for (int i = 1; i <= numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                if (i < numberOfStrings)
                {
                    result += currentString + delimiter;
                }
                else
                {
                    result += currentString;
                }
            }
            Console.WriteLine(result);
        }
    }
}
