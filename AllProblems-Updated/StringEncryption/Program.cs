using System;

namespace StringEncryption
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += Encrypt(letter);
            }
            Console.WriteLine(result);
        }

        static string Encrypt(char letter)
        {
            int asciiCode = (int)letter;
            int firstDigit;
            if (asciiCode >= 100)
            {
                 firstDigit = asciiCode / 100;
            }
            else
            {
                 firstDigit = asciiCode / 10;
            }
            int lastDigit = asciiCode % 10;
            string midPart = Convert.ToString(firstDigit + "" + lastDigit);
            char firstPart = (char)(lastDigit + asciiCode);
            char lastPart = (char) (asciiCode - firstDigit);
            return firstPart + midPart + lastPart;
        }
    }
}
