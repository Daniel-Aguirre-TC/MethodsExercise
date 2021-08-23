using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = GetUserInput("What is your name?");
            string age = GetUserInput($"\nVery nice to meet you, {userName}.\n\nHow old are you?");
            string timeCoding = GetUserInput("\nHow long have you been coding?");
            string favoriteLanguage = GetUserInput("\nWhat is your favorite programming language?");

            Console.WriteLine($"\nAlright {userName}, to recap....\nYou are {age} years old, you have spent {timeCoding} coding,\nand your favorite language is {favoriteLanguage}");

            int numOne = GetUserIntInput("\nNow we will try a math question. Please provide me a number.");
            int numTwo = GetUserIntInput($"\nPerfect, I'll use {numOne} for our first number.\n\nPlease enter a second number.");
            Console.WriteLine($"\n{numOne} + {numTwo} = {numOne + numTwo}");
            Console.ReadKey();
            Console.Clear();

            static int GetUserIntInput(string question)
            {
                Console.WriteLine(question+"\n");
                string reply = Console.ReadLine();
                while(reply == "" || !int.TryParse(reply, out int result))
                {
                    Console.WriteLine("\nPlease enter a valid response\n");
                    reply = Console.ReadLine();
                }
                return int.Parse(reply);
            }
            static string GetUserInput(string question)
            {
                Console.WriteLine(question+"\n");
                string reply = Console.ReadLine();
                    while (reply == "")
                    {
                        Console.WriteLine("\nPlease enter a valid response\n");
                        reply = Console.ReadLine();
                    }
                
                return reply;
            }

        }
    }
}
