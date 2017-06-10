using System;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;

namespace _07GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));

            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine((char)GetMax(first, second));
            }
            else
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }


        }

         static string GetMax(string first, string second)
         {
             if (first.CompareTo(second) > 0)
             {
                 return first;
             }
             else
             {
                 return second;
             }
         }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static int GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
