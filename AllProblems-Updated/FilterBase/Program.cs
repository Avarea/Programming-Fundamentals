using System;
using System.Collections.Generic;

namespace FilterBase
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> employeeAges = new Dictionary<string, int>();
            Dictionary<string, double> employeeSalaries = new Dictionary<string, double>();
            Dictionary<string, string> employeePositions = new Dictionary<string, string>();

            string[] tokens = Console.ReadLine()?.Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "filter")
            {
                string name = tokens[0];
                string value = tokens[1];

                int age;
                double salary;

                if (int.TryParse(value, out age))
                {
                    employeeAges[name] = age;
                }
                else if (double.TryParse(value, out salary))
                {
                    employeeSalaries[name] = salary;
                }
                else
                {
                    employeePositions[name] = value;
                }
                tokens = Console.ReadLine()?.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string condition = Console.ReadLine()?.ToLower();
            if (condition == "position")
            {
                foreach (KeyValuePair<string,string> item in employeePositions)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=',20));
                }
            }
            else if (condition == "age")
            {
                foreach (KeyValuePair<string, int> item in employeeAges)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (KeyValuePair<string, double> item in employeeSalaries)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
