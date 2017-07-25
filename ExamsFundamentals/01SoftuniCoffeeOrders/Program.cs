using System;
using System.Globalization;
//Problem 1 – Softuni Coffee Orders - Exam Preparation III

namespace _01SoftuniCoffeeOrders
{
    class Program
    {
        static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal totalExpence = 0;
            for (int i = 1; i <= ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal totalPrice = daysInMonth * capsulesCount * pricePerCapsule;
                totalExpence += totalPrice;
                Console.WriteLine("The price for the coffee is: ${0:f2}", totalPrice);
            }
            Console.WriteLine("Total: ${0:f2}",totalExpence);

        }
    }
}
