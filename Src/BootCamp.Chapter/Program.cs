using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter a last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter an age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a height in meters: ");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a weight in kilograms: ");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height * 100} centimeters.");

            // formula that is used to calculate the bmi
            var bmi = weight / (height * height);

            // output rounded bmi - rounding is happening to make number look nicer (xx.xx rather than xx.xxxxxxxx)
            Console.WriteLine($"Their BMI is: {Math.Round(bmi, 2)}.");
        }
    }
}
