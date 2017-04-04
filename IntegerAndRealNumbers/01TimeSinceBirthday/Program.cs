using System;


namespace _01TimeSinceBirthday
{
    class Program
    {
        static void Main()
        {
            double years = double.Parse(Console.ReadLine());
            double days = years * 365;
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
