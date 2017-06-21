using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            string ingredient = Console.ReadLine();
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
