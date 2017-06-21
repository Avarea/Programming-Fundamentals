using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0;
            string place = string.Empty;
            double discount = 0;

            if (package == "Normal")
            {
                discount = 0.05;
                if (0 <= groupSize && groupSize <= 50)
                {
                    price = 3000;
                    place = "Small Hall";
                }
                else if (50 < groupSize && groupSize <= 100)
                {
                    price = 5500;
                    place = "Terrace";
                }
                else if (100 < groupSize && groupSize <= 120)
                {
                    price = 8000;
                    place = "Great Hall";
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                    return;
                }
            }
            else if (package == "Gold")
            {
                discount = 0.1;
                if (0 <= groupSize && groupSize <= 50)
                {
                    price = 3250;
                    place = "Small Hall";
                }
                else if (50 < groupSize && groupSize <= 100)
                {
                    price = 5750;
                    place = "Terrace";
                }
                else if (100 < groupSize && groupSize <= 120)
                {
                    price = 8250;
                    place = "Great Hall";
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                    return;
                }
            }
            else if (package == "Platinum")
            {
                discount = 0.15;
                if (0 <= groupSize && groupSize <= 50)
                {
                    price = 3500;
                    place = "Small Hall";
                }
                else if (50 < groupSize && groupSize <= 100)
                {
                    price = 6000;
                    place = "Terrace";
                }
                else if (100 < groupSize && groupSize <= 120)
                {
                    price = 8500;
                    place = "Great Hall";
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                    return;
                }
            }
            double totalPrice = price - (price * discount);

            Console.WriteLine($"We can offer you the {place}");
            Console.WriteLine($"The price per person is {totalPrice/groupSize:f2}$");
        }
    }
}
