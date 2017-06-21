using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            GetRange(num1, num2);
        }

        private static void GetRange(int num1, int num2)
        {
            for (int i = Math.Min(num1,num2); i <= Math.Max(num1,num2); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
