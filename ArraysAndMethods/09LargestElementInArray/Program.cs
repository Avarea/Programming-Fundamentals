using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int largest = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (largest < array[i])
                {
                    largest = array[i];
                }
            }
            Console.WriteLine(largest);
        }
    }
}
