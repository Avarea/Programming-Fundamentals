using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}",GetKilometers(miles));
        }

        private static double GetKilometers(double miles)
        {
            return miles * 1.60934;
        }
    }
}
