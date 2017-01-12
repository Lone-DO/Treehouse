using System;
namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;

            bool excersising = true;
            while (excersising)
            {
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you excersised or type \"quit\" to stop: ");
                string entry = Console.ReadLine();
                entry = entry.ToLower();
                if (entry == "quit")
                {
                    excersising = !excersising;
                }
                else
                {
                    // Add minutes exercised to total 
                    int minutes = int.Parse(entry);
                    runningTotal += minutes;
                    // Display total minutes exercised to the screen 
                    if (runningTotal <= 10 )
                    {
                        Console.WriteLine("You've excersised " + runningTotal + " minutes");
                    }
                    else if (runningTotal <= 20)
                    {
                        Console.WriteLine("You've excersised " + runningTotal + " minutes. Way to go buddy!");
                    }
                    else if (runningTotal <= 35)
                    {
                        Console.WriteLine("You've excersised " + runningTotal + " minutes, You are on Fire today!");
                    }
                    else if (runningTotal <= 60)
                    {
                        Console.WriteLine("You've excersised " + runningTotal + " minutes, Someone is prepping for the League!");
                    }
                    else
                    {
                        Console.WriteLine("To the Championships with you!");
                    }
                    // Repeat until user quits
                }
            }
        }
    }
}