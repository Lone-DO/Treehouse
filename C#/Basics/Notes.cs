using System;
using System.Threading;
namespace Basics
{
    class Notes
    {
        static void Primary(string[] args)
        {
            Wait();
            Variables();
        }
        static void Variables()
        {
            int wholeNumber = 4;
            double pi = 3.14;
            bool status = true;
            string greeting = "Hello world";
            char letter = 'z';

            Console.WriteLine(wholeNumber.GetType());
            Console.WriteLine(pi.GetType());
            Console.WriteLine(status.GetType());
            Console.WriteLine(greeting.GetType());
            Console.WriteLine(letter.GetType());
        }
        static void Wait()
        {
            Console.WriteLine("Waiting...");
            Thread.Sleep(3000);
            Console.WriteLine("Done");
        }
        static void CountToThree()
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            // String Interpolation
            Console.WriteLine($"Insert, {Greet()}");
        }
        static string Greet()
        {
            // \n New Line
            // \t Indent/ Tab
            // \" Double Qoutes
            // \\ Backslash
            return "Hello World";
        }
    }
}
