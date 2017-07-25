using System;

namespace IntegerToBase
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
            string result = string.Empty;
            while (number > 0)
            {
                long reminder = number % toBase;
                result = Convert.ToString(reminder) + result;
                number /= toBase;
            }
            return result;
        }
    }
}
