using System;

namespace RectangleArea
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            GetArea(width, height);
        }

        private static void GetArea(double width, double height)
        {
            Console.WriteLine("{0:f2}", width * height);
        }
    }
}
