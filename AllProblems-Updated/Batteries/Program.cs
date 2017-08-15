using System;
using System.Linq;

namespace Batteries
{
    class Program
    {
        static void Main()
        {
            double[] batteryCapacity = Console.ReadLine()?.Split(' ').Select(double.Parse).ToArray();
            double[] capacityLeft = new double[batteryCapacity.Length];
            double[] batteryUsage = Console.ReadLine()?.Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < batteryUsage.Length; cnt++)
            {
                capacityLeft[cnt] = batteryCapacity[cnt] - (batteryUsage[cnt] * hours);
            }

            for (int cnt = 0; cnt < batteryCapacity.Length; cnt++)
            {
                if (capacityLeft[cnt] > 0)
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", cnt + 1, capacityLeft[cnt], 100 * (capacityLeft[cnt] / batteryCapacity[cnt]));
                }
                else
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", cnt + 1, Math.Ceiling(batteryCapacity[cnt] / batteryUsage[cnt]));
                }
            }
        }
    }
}
