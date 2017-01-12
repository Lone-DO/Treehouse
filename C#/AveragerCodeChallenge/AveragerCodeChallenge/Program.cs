using System;
namespace AveragerCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = 0.0;
            var i = 0;

            while (true)
            {
                // Prompt user for numbers
                Console.Write("Enter a number or type \"done\" to see the average: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    // Display Average Number of all inputs
                    Console.WriteLine("Average: " + (calculate / i));
                    break;
                }
                try
                {
                    // Add inputs to Calculate Array
                    var number = double.Parse(input);

                    if (number <= 0)
                    {
                        Console.WriteLine(number + " is not an acceptable value.");
                        continue;
                    }
                    calculate += number;
                    i += 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }
                // Repeat until user quits
            }
            Console.WriteLine("Goodbye");
        }
    }
}