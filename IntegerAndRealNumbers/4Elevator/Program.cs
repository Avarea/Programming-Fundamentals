using System;


namespace _4Elevator
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityPerElevator = int.Parse(Console.ReadLine());
            double courses = (int)Math.Ceiling((double)numberOfPeople / capacityPerElevator);
            Console.WriteLine(courses);
        }
    }
}
