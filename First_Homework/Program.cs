
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("Enter the temperature degree in Celsius: ");
            float temperature = Convert.ToSingle(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Freezing Weather");
            }
            else if (temperature > 0 && temperature < 10)
            {
                Console.WriteLine("Cold Weather");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Warm weather");
            }
            else
            {
                Console.WriteLine("Hot weather");
            }

            Console.ReadKey();

            // Task 2

            Console.WriteLine("Enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 0 && age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age < 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 19)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadKey();

            // Task 3

            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter temperature in Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"In Farenheheit is {fahrenheit:F2}°F");
            }

            else if (choice == 2)
            {
                Console.WriteLine("Enter temperature in Farenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"In Celsius is {celsius:F2}°C");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

            Console.ReadKey();

            // Task 3 using switch

            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            int choicee = Convert.ToInt32(Console.ReadLine());

            switch (choicee)
            {
                case 1:
                    Console.WriteLine("Enter temperature in Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"In Farenheheit is {fahrenheit:F2}°F");
                    break;

                case 2:
                    Console.WriteLine("Enter temperature in Farenheit: ");
                    double fahrenheitt = Convert.ToDouble(Console.ReadLine());
                    double celsiuss = (fahrenheitt - 32) * 5 / 9;
                    Console.WriteLine($"In Celsius is {celsiuss:F2}°C");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
            Console.ReadKey();
        }

    }
}

