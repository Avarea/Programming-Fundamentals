using System;
using System.Collections.Generic;

namespace ExamShopping
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            string[] tokens = Console.ReadLine()?.Split(' ');

            while (tokens[0] != "shopping")
            {
                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);
                if (!inventory.ContainsKey(product))
                {
                    inventory[product] = quantity;
                }
                else
                {
                    inventory[product] = inventory[product] + quantity;
                }
                tokens = Console.ReadLine()?.Split(' ');
            }

            tokens = Console.ReadLine()?.Split(' ');
            while (tokens[0] != "exam")
            {
                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);
                if (!inventory.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    int quantityInStock = inventory[product];
                    if (quantityInStock <= 0)
                    {
                        inventory[product] = 0;
                        Console.WriteLine($"{product} out of stock"); ;
                    }
                    else
                    {
                        inventory[product] = inventory[product] - quantity;
                    }
                }
                tokens = Console.ReadLine()?.Split(' ');
            }

            foreach (KeyValuePair<string,int> item in inventory)
            {
                var quantity = item.Value;

                if (quantity > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
