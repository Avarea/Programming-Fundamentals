using System;

namespace DebuggingMiningCoins
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;
            decimal totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;
                int digit2 = (number % 100) / 10;
                int digit3 = number % 10;

                totalValue += ((decimal)(digit1 + digit2 + digit3) / n);
                int asciIcode;

                if (i % 2 == 1)
                {
                    asciIcode = int.Parse(digit1 + "" + digit3) - digit2;
                }
                else
                {
                    asciIcode = int.Parse(digit1 + "" + digit3) + digit2;

                }

                if ((asciIcode >= 65 && asciIcode <= 90)|| (asciIcode >= 97 && asciIcode <= 122))
                {
                    decrypted += (char)asciIcode;
                }
            }


            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", (float)totalValue);
        }
    }
}
