using System;
namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningTotal = 0.0;

            while (true)
            {
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you excersised or type \"quit\" to stop: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                try
                {
                    // Add minutes exercised to total 
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Keep it up!");
                    }
                    else if (minutes <= 20)
                    {
                        Console.WriteLine("Way to go buddy!");
                    }
                    else if (minutes <= 35)
                    {
                        Console.WriteLine("You are on Fire today!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Someone is prepping for the League!");
                    }
                    else
                    {
                        Console.WriteLine("To the Championships with you!");
                    }
                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }

                // Display total minutes exercised to the screen 
                Console.WriteLine("You've entered " + runningTotal + " minutes.");
                // Repeat until user quits
            }
            Console.WriteLine("Goodbye");
        }
    }
}