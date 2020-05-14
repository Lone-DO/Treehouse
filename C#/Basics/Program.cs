using System;

namespace Basics
{
    class Program
    {

        static string Eat(string str1, string str2)
        {
            string tasty = $"I think {str1} and {str2} are tasty!";
            return tasty;
        }
        static string Ask(string question)
        {
            Console.WriteLine($"{question} ");
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the cat food store!");
            string answer = Ask("How many cans are you ordering?");
            Console.WriteLine($"You entered: {answer} cans");
        }
    }
}
