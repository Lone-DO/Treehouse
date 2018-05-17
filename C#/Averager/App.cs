using System;

namespace Csharp.Averager
{
   class App
   {
      static void Main()
      {
         double avgPool = 0,
            count = 0,
            result = 0;

         while (true)
         {
            //Prompt user to input a number
            Console.Write("Enter a number or type \"done\" to see the average: ");
            var input = Console.ReadLine();

            try
            {
               //Loop until user says "done"
               if (input.ToLower() == "done")
               {
                  //Write average results (numberpool / count)
                  Console.WriteLine("Average: " + result);
                  //Prompt to restart app or "quit"
                  Console.WriteLine("Would you like to Continue, Restart, or Quit (c, r, q)?");
                  input = Console.ReadLine();

                  if (input.ToLower() == "q" || input.ToLower() == "quit")
                  {
                     break;
                  }
                  else if (input.ToLower() == "c" || input.ToLower() == "continue")
                  {
                     Console.WriteLine("Continue...");
                     continue;
                  }
                  else
                  {
                     avgPool = 0;
                     count = 0;
                     result = 0;
                     Console.WriteLine("Application has been reset");
                     continue;
                  }
               }
               //Add input to numberPool, incriment count++
               avgPool += double.Parse(input);
               count++;
               result = (avgPool / count);
               /**numberPool(5.5 + 4.2 + 99) / count(3) = Average(36.2333333)*/
            }
            catch (FormatException)
            {
               Console.WriteLine(input + " is not a valid number, Please input a valid number");
            }
         }
         Console.WriteLine("Goodbye, Press any key to Close!");
         Console.ReadKey();
      }
   }
}

/**
 Averager
Repeatedly prompt the user for numbers. Add all of the numbers together. 
   When the user types in “done”,
   print the average of all of the numbers by dividing the total by the number of numbers entered.

treehouse:~/workspace$ mcs Program.cs && mono Program.exe
Enter a number or type "done" to see the average: 5.5
Enter a number or type "done" to see the average: bogus
That is not valid input.
Enter a number or type "done" to see the average: 4.2
Enter a number or type "done" to see the average: 99
Enter a number or type "done" to see the average: done
Average: 36.2333333333333
treehouse:~/workspace 
    
*/
