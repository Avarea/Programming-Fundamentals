using System;

namespace _11OddNumber
{
    class Program
    {
        static void Main()
        {

            for (int i = 0; i < int.MaxValue; i++)
            {
                int num = Math.Abs(int.Parse(Console.ReadLine()));
                if (num % 2 == 1)
                {
                    Console.WriteLine("The number is: {0}", num);
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}
