using System;

namespace EmployeeData
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            GetData(name, age, id, salary);
        }

        private static void GetData(string name, int age, int id, double salary)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id:D8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
