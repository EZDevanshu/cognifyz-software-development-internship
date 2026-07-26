using System;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Temperature Converter =====");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (choice)
            {
                case 1:
                    result = (temperature * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + result);
                    break;

                case 2:
                    result = (temperature - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}