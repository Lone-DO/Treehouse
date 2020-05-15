using System;

namespace Practice_Loops
{
    class Program
    {
        static void Square(string number)
        {
            Console.WriteLine($"{number} multiplied by itself is equal to {double.Parse(number) * 2}\n");
        }
        static string Prompt(string Question)
        {
            Console.WriteLine(Question);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = Prompt("Please enter a number: ");
                if (double.TryParse(input, out _)) Square(input);
                else if (input.ToLower() == "quit") Console.WriteLine("Quitting Application, GoodBye!");
                else Console.WriteLine("User entered invalid number, please try again\n");
            } while (input.ToLower() != "quit");
        }
    }
}
