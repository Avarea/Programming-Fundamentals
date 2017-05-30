using System;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double totalCost = 0;
            string place = string.Empty;

            if (size <= 50 && package == "Normal")
            {
                totalCost += 3000;
                totalCost = totalCost - (totalCost * 5 / 100);
                place = "Small Hall";
            }
            else if (size <= 50 && package == "Gold")
            {
                totalCost += 3250;
                totalCost = totalCost - (totalCost * 10 / 100);
                place = "Small Hall";
            }
            else if (size <= 50 && package == "Platinum")
            {
                totalCost += 3500;
                totalCost = totalCost - (totalCost * 15 / 100);
                place = "Small Hall";
            }

            else if (size <= 100 && package == "Normal")
            {
                totalCost += 5500;
                totalCost = totalCost - (totalCost * 5 / 100);
                place = "Terrace";
            }
            else if (size <= 100 && package == "Gold")
            {
                totalCost += 5750;
                totalCost = totalCost - (totalCost * 10 / 100);
                place = "Terrace";
            }
            else if (size <= 100 && package == "Platinum")
            {
                totalCost += 6000;
                totalCost = totalCost - (totalCost * 15 / 100);
                place = "Terrace";
            }

            else if (size <= 120 && package == "Normal")
            {
                totalCost += 8000;
                totalCost = totalCost - (totalCost * 5 / 100);
                place = "Great Hall";
            }
            else if (size <= 120 && package == "Gold")
            {
                totalCost += 8250;
                totalCost = totalCost - (totalCost * 10 / 100);
                place = "Great Hall";
            }
            else if (size <= 120 && package == "Platinum")
            {
                totalCost += 8500;
                totalCost = totalCost - (totalCost * 15 / 100);
                place = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            Console.WriteLine("We can offer you the {0}", place);
            Console.WriteLine("The price per person is {0:f2}$", totalCost / size);
        }
    
    }
}

