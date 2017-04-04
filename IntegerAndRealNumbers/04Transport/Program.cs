using System;


namespace _04Transport
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling(numberOfPeople / 24.00);
            Console.WriteLine(courses);
        }
    }
}
