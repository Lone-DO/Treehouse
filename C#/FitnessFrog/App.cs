using System;

namespace Csharp.FitnessFrog
{
   class App
   {
      static void Main()
      {
         double workoutTotal = 0;

         while (true)
         {
            //Prompt user for minutes excersised
            Console.WriteLine("Enter how many minutes you excercised, or enter 'quit' to stop the application: ");

            string entry = Console.ReadLine();

            try
            {
               //Loop till user quits
               if (entry.ToLower() == "quit")
               {
                  break;
               }

               double time = double.Parse(entry);

               if (time <= 0)
               {
                  Console.WriteLine(time + " is not an acceptable value");
                  continue;
               }
               else if (time <= 10)
               {
                  Console.WriteLine("Way to go hot stuff");
               }
               else if (time <= 30)
               {
                  Console.WriteLine("You must be a ninja warrior in training");
               }
               else if (time <= 60)
               {
                  Console.WriteLine("Aiming for 1st place");
               }
               else
               {
                  Console.WriteLine("Now you are just showing off...");
               }

               //Add minutes to total
               workoutTotal += time;

               //Display total minutes excersised
               Console.WriteLine("You've Excersised for " + workoutTotal + " minutes.");


            }
            catch (FormatException)
            {
               Console.WriteLine("Input is invalid, please input a number...");
            }

         }
         Console.WriteLine("Goodbye");
      }
   }
}