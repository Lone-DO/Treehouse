using System;
namespace ArithmeticCalculatorCodeChallenge
{
    class Program
    {//Create a calculator that does one arithmetic operation at a time and prints the result to the screen
        static void Main(string[] args)
        {
            var calculator = 0.0;

            while (true)
            {
                //Prompt the user for a number.
                Console.WriteLine("Enter a Number or type \"quit\" to stop: ");
                var input = Console.ReadLine();
                //Repeat until the user types in “quit” at any of the prompts.
                if (input.ToLower() == "quit")
                {
                    break;
                }

                var number1 = double.Parse(input);
                
                //Prompt the user for an operation (+- / *).
                Console.WriteLine("Enter a operation: ");
                var operation = Console.ReadLine();
                var _op = operation;
                //Prompt the user for another number.
                Console.WriteLine("Enter another Number: ");
                input = Console.ReadLine();
                var number2 = double.Parse(input);
                
                try
                {
                    //Perform the operation.
                    calculator = number1 + number2;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }
                //Print the result to the screen.
                Console.WriteLine(calculator);
            }
            //Extra Credit: Add the power operator using the ^ symbol.You can calculate a number raised to a power using the
            Console.WriteLine("Goodbye");
        }
        
    }
}
