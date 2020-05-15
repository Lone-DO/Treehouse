using System;

namespace Practice_Input_Outputs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Declare and assign a "thing" string variable.
            // Example: "movie", "book", "color", etc.
            string thing = "movie";
            // TODO Prompt the user with the text "What is your name?" 
            // and assign their value to a "name" string variable.
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            // TODO Prompt the user with the text 
            // "What is your favorite <thing>?" 
            // and assign their value to a "favoriteThing" string variable.
            Console.WriteLine($"What is your favorite {thing}? ");
            string favoriteThing = Console.ReadLine();
            // TODO Write the user's name and favorite thing to the console.
            // Example: "My name is James and my favorite movie is Toy Story."
            Console.WriteLine($"My name is {name} and my favorite {thing} is {favoriteThing}.");
        }
    }
}

