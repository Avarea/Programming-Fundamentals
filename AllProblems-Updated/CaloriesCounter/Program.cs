using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < counter; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                switch (ingredients)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
