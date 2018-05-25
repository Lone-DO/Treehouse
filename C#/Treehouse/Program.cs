using System;

class Program
{
    static void Main()
    {
        HelloWorld();
    }

    static void HelloWorld()
    {
        Console.WriteLine("Please insert your name");

        string name = Console.ReadLine();

        Console.WriteLine("Please insert what you like");
        string item = Console.ReadLine();

        Console.WriteLine("Hello World, my name is " + name + " and i like " + item + "!");
    }
}