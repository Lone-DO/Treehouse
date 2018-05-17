/*Write an interactive quiz. It should ask the user three multiple-choice or true/false questions about something.
It must keep track of how many they get wrong, and print out a "score" at the end.*/
// BUG: User puts in int value beyond an answer, Question drops error and skips ahead

using System;

namespace Csharp.InteractiveQuiz
{
    class App
    {
        private static int question = 1;
        private static int incorrect = 0;
        private static int score = 0;
        private static string correct = "Answer was correct";
        private static string wrong = "Answer was incorrect";
        private static string error = " is not a valid choice, Please try again...";

        static void Main()
        {
            Console.WriteLine("Answer the following mutliple choice questions with corresponding number");
            try
            {
                switch (question)
                {
                    case 1:
                        question1();
                        goto case 2;
                    case 2:
                        question2();
                        goto case 3;
                    case 3:
                        question3();
                        break;
                }
                //Display results
                Console.WriteLine("Your score is " + score + " with " + incorrect + " incorrect answers");
                //Prompt if user wants to "try again" or "quit"
            }
            catch (FormatException)
            {
                Console.WriteLine(" is not a valid choice, Please try again...");
            }
        }
        static void question1()
        {
            Console.WriteLine("What color is the sky, 1)Blue, 2)Red, 3)Green");
            var answer = Console.ReadLine();
            try
            {
                switch (int.Parse(answer))
                {
                    case 1:
                        Console.WriteLine(correct);
                        score++; //Tally scrore & incorrect answers.
                        break;
                    case 2:
                    case 3:
                        incorrect++;
                        Console.WriteLine(wrong);
                        break;
                    default:
                        Console.WriteLine("Invalid Answer");
                        break;
                }
            }
            catch (FormatException)
            {
                //Input Validation
                Console.WriteLine(answer + error);
                question1();
            }

        }
        static void question2()
        {
            Console.WriteLine("Websites are designed using, 1)Software, 2)CSS, 3)JavaScript");
            var answer = Console.ReadLine();
            try
            {
                switch (int.Parse(answer))
                {
                    case 2:
                        Console.WriteLine(correct + " " + answer + ") is the answer");
                        score++;
                        break;
                    case 1:
                    case 3:
                        incorrect++;
                        Console.WriteLine(wrong);
                        break;
                    default:
                        Console.WriteLine("Invalid Answer");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(answer + error);
                question2();
            }

        }
        static void question3()
        {
            Console.WriteLine("What framework is this quiz written in?, 1)C#, 2)PHP, 3).NET");
            var answer = Console.ReadLine();
            try
            {
                switch (int.Parse(answer))
                {
                    case 1:
                        Console.WriteLine(correct);
                        score++;
                        break;
                    case 2:
                    case 3:
                        incorrect++;
                        Console.WriteLine(wrong);
                        break;
                    default:
                        Console.WriteLine("Invalid Answer");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(answer + error);
                question3();
            }

        }
    }
}

