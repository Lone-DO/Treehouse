using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        static void Variables()
        {
            int wholeNumber = 4;
            double pi = 3.14;
            bool status = true;
            string greeting = "Hello world";
            char letter = 'z';

            System.Console.WriteLine(wholeNumber.GetType());
            System.Console.WriteLine(pi.GetType());
            System.Console.WriteLine(status.GetType());
            System.Console.WriteLine(greeting.GetType());
            System.Console.WriteLine(letter.GetType());
        }
    }
}
