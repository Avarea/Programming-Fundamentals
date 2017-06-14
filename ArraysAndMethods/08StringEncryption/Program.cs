using System;
using System.Runtime.InteropServices;

namespace _08StringEncryption
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                char characters = char.Parse(Console.ReadLine());
                result += Encrypt(characters);
            }
            Console.WriteLine(result);

        }

        static string Encrypt(char characters)
        {
            string result = String.Empty;

            int partOne = (characters);
            int firstdigit = 0;
            if (partOne < 100)
            {
                firstdigit = (partOne / 10);
            }
            else
            {
                firstdigit = 1;
            }
            int lastDigit = partOne % 10;
            char firstLetter = Convert.ToChar(partOne + lastDigit);
            char lastLetter = Convert.ToChar(partOne - firstdigit);
            result = firstLetter + Convert.ToString(firstdigit) + Convert.ToString(lastDigit) + lastLetter;

            return result;

        }
    }
}
