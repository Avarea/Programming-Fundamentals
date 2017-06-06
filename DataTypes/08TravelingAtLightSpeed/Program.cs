using System;
using System.Globalization;

namespace _08TravelingAtLightSpeed
{
    class Program
    {
        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal lightYear = 9450000000000;
            decimal lightSpeed = 300000;

            decimal total = (lightYear / lightSpeed) * input;



            TimeSpan diff = TimeSpan.FromSeconds((double)total);
            string formatted = string.Format(
                  CultureInfo.CurrentCulture,
                  "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
                  diff.Days / 7,
                  diff.Days % 7,
                  diff.Hours,
                  diff.Minutes,
                  diff.Seconds);

            Console.WriteLine(formatted);
        }
    }
}
