using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Dictionary<string, int>();
            StringBuilder stringBuilder = new StringBuilder();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                string[] splittedInput = input?.Split(' ');

                if (splittedInput.Length < 3)
                {
                    continue;
                }

                string currentCommand = splittedInput[0];
                string product = splittedInput[1];
                int quantity = int.Parse(splittedInput[2]);

                switch (currentCommand.ToLower())
                {
                    case "stock":
                    {
                        if (!stock.ContainsKey(product))
                        {
                            stock[product] = quantity;
                        }
                        else
                        {
                            stock[product] = stock[product] + quantity;
                        }
                    }
                        break;
                    case "buy":
                    {
                        if (!stock.ContainsKey(product))
                        {
                            stringBuilder.AppendLine($"{product} doesn't exist");
                        }
                        else
                        {
                            int quantityInStock = stock[product];

                            if (quantityInStock <= 0)
                            {
                                stock[product] = 0;
                                stringBuilder.AppendLine($"{product} out of stock");
                            }
                            else
                            {
                                stock[product] = stock[product] - quantity;
                            }
                        }
                    }
                        break;
                }
            }
            while (input != "exam time");

            Console.Write(stringBuilder.ToString());
            foreach (var productInStock in stock)
            {
                var quantity = productInStock.Value;

                if (quantity > 0)
                {
                    Console.WriteLine($"{productInStock.Key} -> {productInStock.Value}");
                }
            }
        }
    }
}