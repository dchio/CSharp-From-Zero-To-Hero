using System;
using System.Runtime.Intrinsics.X86;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your first name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height in meters: ");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your weight in kilograms: ");
            var weight = double.Parse(Console.ReadLine());

            var bmi = weight / (height * height);

            Console.WriteLine(Math.Round(bmi, 2));
        }
    }
}
