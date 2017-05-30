using System;

namespace _04Hotel
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double price = 0;

            if (month == "May" || month == "October")
            {
                if (month == "October" && nightsCount > 7)
                {
                    price = (50 * 0.95) * (nightsCount - 1);
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else if (nightsCount > 7)
                {
                    price = (50 * 0.95) * nightsCount;
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", 50 * nightsCount);
                }
                Console.WriteLine("Double: {0:f2} lv.", 65 * nightsCount);
                Console.WriteLine("Suite: {0:f2} lv.", 75 * nightsCount);
            }

            else if (month == "June" || month == "September")
            {
                if (month == "September" && nightsCount > 7)
                {
                    price = 60 * (nightsCount - 1);
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else if (month == "June" && nightsCount > 7)
                {
                    price = (60 * nightsCount);
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", 60 * nightsCount);
                }
                if (nightsCount > 14)
                {
                    price = (60 * 0.90) * nightsCount;
                    Console.WriteLine("Double: {0:f2} lv.", price);
                }
                else
                {
                    Console.WriteLine("Double: {0:f2} lv.", 72 * nightsCount);
                }
                Console.WriteLine("Suite: {0:f2} lv.", 82 * nightsCount);
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                Console.WriteLine("Studio: {0:f2} lv.", 68 * nightsCount);
                Console.WriteLine("Double: {0:f2} lv.", 77 * nightsCount);

                if (nightsCount > 14)
                {
                    price = (89 * 0.85) * nightsCount;
                    Console.WriteLine("Suite: {0:f2} lv.", price);
                }
                else
                {
                    Console.WriteLine("Suite: {0:f2} lv.", 89 * nightsCount);

                }

            }


        }
    }
}
