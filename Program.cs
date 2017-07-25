using System;

//Problem 1 – Hornet Wings - Exam Preparation V
namespace _01HornetWings
{
    class Program
    {
        static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceFor1000flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            
            double distance = (wingFlaps / 1000) * distanceFor1000flaps;
            double totalSeconds = wingFlaps / 100;
            double timeAfterRest = (wingFlaps / endurance) * 5 + totalSeconds;

            Console.WriteLine("{0:f2} m.", distance);
            Console.WriteLine("{0} s.", timeAfterRest);

        }
    }
}
