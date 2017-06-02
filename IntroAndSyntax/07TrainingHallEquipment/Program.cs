using System;

namespace _07TrainingHallEquipment
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            double totalCost = 0;

            for (int i = 1; i <= items; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                totalCost += itemPrice * itemCount;

                if (itemCount > 1)
                {
                    itemName += "s";
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
            }
            if (budget >= totalCost)
            {
                Console.WriteLine("Subtotal: ${0:f2}", totalCost);
                Console.WriteLine("Money left: ${0:f2}", budget - totalCost);
            }
            else
            {
                Console.WriteLine("Subtotal: ${0:f2}", totalCost);
                Console.WriteLine("Not enough. We need ${0:f2} more.", Math.Abs(budget - totalCost));
            }

        }
    }
}
