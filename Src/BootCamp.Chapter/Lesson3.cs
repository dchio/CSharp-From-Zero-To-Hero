using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string questionMessage = "What is your ";

            var firstName = PromptString(questionMessage + "first name");
            var lastName = PromptString(questionMessage + "lirst name");

            var age = PromptInt(questionMessage + "age");

            var weight = PromptFloat(questionMessage + "weight in kg");
            var height = PromptFloat(questionMessage + "height in meters");

            var bmi = CalculateBmi(weight, height);

            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} m.");
            Console.WriteLine($"His BMI is: {bmi}.");

        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var userInput = Console.ReadLine();
            var isNumber = int.TryParse(userInput, out int input);
                  
            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            else if (!isNumber)
            {
                Console.Write($"\"{userInput}\" is not a valid number.");
                return -1;
            }
            else if (isNumber && input == 0)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return 0;
            }

            return input;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var userInput = Console.ReadLine();
            var isNumber = float.TryParse(userInput, NumberStyles.Number, CultureInfo.InvariantCulture, out float input);

            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            else if (!isNumber && input != 0)
            {
                Console.Write($"\"{userInput}\" is not a valid number.");
                return -1;
            }
            else if (!isNumber)
            {
                Console.Write($"\"{userInput}\" is not a valid number.");
                return -1;
            }
            else if (isNumber && input == 0)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return 0f;
            }

            return input;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            else
            {
                return weight / (height * height);
            }
        }

    }
}
