using System;

namespace _17CypherRoulette
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string result = string.Empty;
            bool isReversed = false;
            string lastChar = string.Empty;

            for (int i = 1; i <= input; i++)
            {

                string currentString = Console.ReadLine();

                if (currentString == lastChar)
                {
                    result = string.Empty;
                    if (currentString == "spin")
                    {
                        input++;
                    }
                }

                else
                {
                    if (currentString == "spin")
                    {
                        isReversed = !isReversed;
                        input++;
                    }
                    else
                    {
                        if (isReversed)
                        {
                            result = currentString + result;
                        }
                        else
                        {
                            result = result + currentString;
                        }
                    }
                }
                lastChar = currentString;
            }
            Console.WriteLine(result);
        }
    }
}
