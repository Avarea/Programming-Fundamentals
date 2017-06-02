using System;

namespace _05BPMCounter
{
    class Program
    {
        static void Main()
        {
            int bpm = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.00, 1);


            int minutes = beats / bpm;
            double seconds = Math.Floor(60 * (beats / (double)bpm) - minutes * 60);


            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes, seconds);
        }
    }
}
