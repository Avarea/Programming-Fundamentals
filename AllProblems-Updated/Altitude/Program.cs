using System;
using System.Linq;

namespace Altitude
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine()?.ToLower().Split(' ').ToArray();
            double currentAltitude = double.Parse(array[0]);

            for (int cntIndex = 1; cntIndex < array.Length - 1; cntIndex += 2)
            {
                if (currentAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
                switch (array[cntIndex])
                {
                    case "up":
                        currentAltitude += double.Parse(array[cntIndex + 1]);
                        break;
                    case "down":
                        currentAltitude -= double.Parse(array[cntIndex + 1]);
                        break;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {currentAltitude}m");
        }
    }
}
