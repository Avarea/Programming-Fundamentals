using System;

namespace _03Megapixels
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = (width * height / 1000000);
            Console.WriteLine("{0}x{1} => {2}MP",width, height, Math.Round(result, 1));
            
        }
    }
}
