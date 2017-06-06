using System;

namespace _05DistanceOfTheStars
{
    class Program
    {
        static void Main()
        {
            decimal nearestStar = 4.22M;
            decimal galaxy = 26000M;
            decimal milkyWay = 100000M;
            decimal universe = 46500000000M;

            decimal lightYear = 9450000000000M;

            Console.WriteLine("{0:e2}",nearestStar * lightYear);
            Console.WriteLine("{0:e2}", galaxy * lightYear);
            Console.WriteLine("{0:e2}", milkyWay * lightYear);
            Console.WriteLine("{0:e2}", universe * lightYear);


        }
    }
}
