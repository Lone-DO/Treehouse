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
        static void Charge(int amount)
        {
            double total = 0;
            if (amount >= 100)
            {
                total = amount * 1.5; //$1.75
            }
            else if (amount >= 50)
            {
                total = amount * 1.75; // $1.50
            }
            else
            {
                total = amount * 2; //$2
            }

            Console.WriteLine($"For {amount} cans, your total is: ${total}");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the cat food store!");
            int quantity = int.Parse(Ask("How many cans are you ordering?"));
            Charge(quantity);
        }
    }
}
