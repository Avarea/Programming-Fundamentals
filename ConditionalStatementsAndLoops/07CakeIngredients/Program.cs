using System;

namespace _07CakeIngredients
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            for (int i = 0; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", count);
                    break;
                }
                count++;
                Console.WriteLine("Adding ingredient {0}.", ingredient);
            }
        }
    }
}
