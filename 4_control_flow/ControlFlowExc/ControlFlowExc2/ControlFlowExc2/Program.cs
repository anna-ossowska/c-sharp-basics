using System;

namespace ControlFlowExc2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.
            string input = "";
            int sum = 0;

            while (input != "ok")
            {
                Console.WriteLine("Enter a number: ");
                Console.WriteLine("Or type 'ok' to exit");
                input = Console.ReadLine();

                var inputToInt = Convert.ToInt32(input);
                sum += inputToInt;

                Console.WriteLine($"The sum of typed numbers: {sum}");
            }

        }
    }
}
