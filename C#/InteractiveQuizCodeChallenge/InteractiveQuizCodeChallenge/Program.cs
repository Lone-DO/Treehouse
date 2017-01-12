using System;
namespace InteractiveQuizCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var correct = 0;
            var wrong = 0;
            var questions = new[] {
                "What is 2 + 2? a) 4, b) 6, c) 20 ",
                "What is 2 * 2? a) 20, b) 23, c) 4 ",
                "What is 2 / 2? a) 3, b) 1, c) 0 "
            };
            var answers = new[] {"a","c", "b"};
            var i = 0;

            // Prompt user to answer 3 questions
            while (true)
            {
                if(i == questions.Length)
                {
                    break;
                }
                try
                {
                    Console.WriteLine((questions[i]));
                    var input = Console.ReadLine();

                    if (input.ToLower() == (answers[i]))
                    {
                        correct += 1;
                    }
                    else
                    {
                        wrong += 1;
                    }
                    i += 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }
            }
            // Print out scores 
            Console.WriteLine("You got " + correct + " questions right, and " + wrong + " questions wrong.");
            Console.WriteLine("Goodbye");
        }
    }
}

