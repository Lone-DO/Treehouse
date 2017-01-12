using System;
namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for minutes exercised 
            Console.Write("Enter how many minutes you excersised: ");

            string entry = System.Console.ReadLine();

            // Add minutes exercised to total 

            // Display total minutes exercised to the screen 
            Console.WriteLine("You've excersised " + entry + " minutes");
            // Repeat until user quits 
        }
    }
}
