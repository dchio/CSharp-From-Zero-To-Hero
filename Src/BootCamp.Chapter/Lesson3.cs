using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static void Demo()
        {
            string questionMessage = "What is your ";

            var firstName = PromptString(questionMessage + "first name");
            var lastName = PromptString(questionMessage + "lirst name");



        }

        static int PromptInt(string message)
        {
            Console.WriteLine(message + "?");
            var input = int.Parse(Console.ReadLine());
                        
            return input;
        }

        static string PromptString(string message)
        {
            Console.WriteLine(message + "?");
            var input = Console.ReadLine();

            return input;
        }

        static float PromptFloat(string message)
        {
            Console.WriteLine(message + "?");
            var input = float.Parse(Console.ReadLine());

            return input;
        }


    }
}
