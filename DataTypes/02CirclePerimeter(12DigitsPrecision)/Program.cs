using System;

namespace _02CirclePerimeter_12DigitsPrecision_
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", 2 * Math.PI * radius);
        }
    }
}
