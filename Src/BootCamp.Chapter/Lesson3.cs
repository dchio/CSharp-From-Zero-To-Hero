using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

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
            var input = int.Parse(Console.ReadLine());
                        
            return input;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = float.Parse(Console.ReadLine());

            return input;
        }

        public static float CalculateBmi(float weight, float height)
        {
            var bmi = weight / (height * height);

            return bmi;
        }


    }
}
