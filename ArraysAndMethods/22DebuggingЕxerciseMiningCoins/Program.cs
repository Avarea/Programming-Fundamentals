﻿using System;

namespace _22DebuggingЕxerciseMiningCoins
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;
            float totalValue = 0f;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                totalValue += (digit1 + digit2 + digit3) / (float)n;
                int asciiCode = 0;

                if (i % 2 != 0)
                {
                    asciiCode = ((digit1 * 10) + digit3) + digit2;
                }
                else
                {
                    asciiCode = ((digit1 * 10) + digit3) - digit2;
                }

                if ((asciiCode >= 65 && asciiCode <= 90) || (asciiCode >= 97 && asciiCode <= 122))
                {
                    decrypted += (char)asciiCode;
                }

            }

            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
