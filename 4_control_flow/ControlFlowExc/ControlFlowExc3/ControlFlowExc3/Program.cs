using System;
using System.Collections.Generic;

namespace ControlFlowExc3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //    For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            string input = "";
            int factorial = 1;

            while (input != "exit")
            {
                Console.WriteLine("Enter a number: ");
                Console.WriteLine("Or type 'exit'.");
                input = Console.ReadLine();
                var inputToInt = Convert.ToInt32(input);

                // Create an array of decremented values;
                var arrDecrement = new List<int>();
                for (var i = inputToInt; i >= 1; i--)
                {
                    arrDecrement.Add(i);
                }

                // Multiple the array elements
                foreach (var num in arrDecrement)
                {
                    factorial *= num;
                }

                // Display the msg
                Console.WriteLine($"{inputToInt}! = {factorial}");

                // Reset the factorial
                factorial = 1;
            }
        }
    }
}
