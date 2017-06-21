using System;

namespace Hotel
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double price = 0;
  
            //For suite and more than 14 nights in July, August and December: 15 % discount
            if (month == "May" || month == "October")
            {
                if (month == "October" && nightCount > 7)
                {
                    price = (50 * 0.95) * (nightCount - 1);
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else if (nightCount > 7)
                {
                    price = (50 * 0.95) * nightCount;
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", 50 * nightCount);
                }
                Console.WriteLine("Double: {0:f2} lv.", 65 * nightCount);
                Console.WriteLine("Suite: {0:f2} lv.", 75 * nightCount);
            }
            else if (month == "June" || month == "September")
            {
                if (month == "September" && nightCount > 7)
                {
                    price = 60 * (nightCount - 1);
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else if (month == "June" && nightCount > 7)
                {
                    price = (60 * nightCount);
                    Console.WriteLine("Studio: {0:f2} lv.", price);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", 60 * nightCount);
                }
                if (nightCount > 14)
                {
                    price = (60 * 0.90) * nightCount;
                    Console.WriteLine("Double: {0:f2} lv.", price);
                }
                else
                {
                    Console.WriteLine("Double: {0:f2} lv.", 72 * nightCount);
                }
                Console.WriteLine("Suite: {0:f2} lv.", 82 * nightCount);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", 68 * nightCount);
                Console.WriteLine("Double: {0:f2} lv.", 77 * nightCount);
                if (nightCount > 14)
                {
                    Console.WriteLine("Suite: {0:f2} lv.", (89 *0.85) * nightCount);
                }
                else
                {
                    Console.WriteLine("Suite: {0:f2} lv.", 89  * nightCount);
                }
            }
        }
    }
}
