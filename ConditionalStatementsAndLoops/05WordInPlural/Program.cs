using System;

namespace _05WordInPlural
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y") == true)
            {
                char y = 'y';
                word = word.TrimEnd(y);
                word += "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }

            Console.WriteLine(word);
        }
    }
}
