using System;

namespace _03ExactProductOfRealNumbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            decimal product = 1;

            for (int i = 0; i < input; i++)
            {
                decimal num1 = decimal.Parse((Console.ReadLine()));
                product *= num1;
            }
            Console.WriteLine(product);
        }
    }
}
