using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExactProductOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal exactProduct = 1;
            for (int i = 0; i < numbers; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                exactProduct *= number;
            }
            Console.WriteLine(exactProduct);
        }
    }
}
