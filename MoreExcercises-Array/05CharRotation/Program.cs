using System;
using System.Linq;


namespace _05CharRotation
{
    class Program
    {
        static void Main()
        {
            string characters = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] result = new char[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result[i] += (char)(characters[i] - numbers[i]);
                }
                else
                {
                    result[i] += (char)(characters[i] + numbers[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
