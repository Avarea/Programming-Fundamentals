using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            GetTime(hours, minutes);
        }

        private static void GetTime(int hours, int minutes)
        {
            minutes += 30;
            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine("{0:D1}:{1:D2}", hours, minutes);
        }
    }
}
