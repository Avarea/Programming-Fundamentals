using System;


namespace _3ExactSumOfRealNumbers
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal exactProduct = 0;
            for (int i = 0; i < numbers; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                exactProduct += number;
            }
            Console.WriteLine(exactProduct);
        }
    }
}
