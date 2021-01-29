using System;

namespace ControlFlowExc4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 - Write a program that picks a random number between 1 and 10.
            //    Give the user 4 chances to guess the number.
            //    If the user guesses the number, display “You won"; otherwise, display “You lost".
            //    (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            int chances = 4;

            // Computer picks a random number 
            var random = new Random();
            int computerChoice = random.Next(1, 10);


            while (chances > 0)
            {
                // User picks a random number
                Console.WriteLine($"Pick a random number between 1 and 10");
                var userChoice = Convert.ToInt32(Console.ReadLine());
                --chances;

                if (computerChoice == userChoice)
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine($"You guessed the number in the {4 - chances} round!");
                    break;
                }
                else if (chances == 1)
                {
                    Console.WriteLine($"You have {chances} chance to guess."); // Singular form
                }
                else if (chances == 0)
                {
                    Console.WriteLine("You lost");
                }
                else
                {
                    Console.WriteLine($"You have {chances} chances to guess."); // Plural form
                }
            }
        }
    }
}