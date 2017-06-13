using System;

namespace _05IntegerToBase
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number, toBase));
        }

        static string IntegerToBase(long number, int toBase)
        {
            string result = null;
            int count = 1;
            long reminder = 0;


            while (number > 0)
            {
                if (count == 1)
                {
                    reminder = number % toBase;
                    result = reminder + result;
                    number /= toBase;
                }
                else
                {
                    reminder = number % toBase;
                    result = reminder + result;
                    number /= toBase;
                }
                count++;
            }
            return result;

        }
    }
}
