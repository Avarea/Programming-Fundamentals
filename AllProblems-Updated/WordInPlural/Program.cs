using System;

namespace WordInPlural
{
    class Program
    {
        static void Main()
        {
            string noun = Console.ReadLine();

            Console.WriteLine(GetPlural(noun));
        }

        private static string GetPlural(string noun)
        {
            string result = string.Empty;

            if (noun.EndsWith("y"))
            {
                result = noun.Replace('y', 'i') + "es";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                result = noun + "es";
            }
            else
            {
                result = noun + "s";
            }
            return result;
        }
    }
}
