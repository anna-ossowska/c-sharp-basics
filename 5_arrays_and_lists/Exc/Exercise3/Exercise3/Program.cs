using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 - Write a program and ask the user to enter 5 numbers.
            //    If a number has been previously entered, display an error message and ask the user to re-try.
            //    Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            string input = "";
            var total = new List<int>();

            while (input != "exit")
            {
                Console.WriteLine("Enter 5 unique numbers separated by comma: ");
                Console.WriteLine("Or type 'exit' to close the program.");

                input = Console.ReadLine();

                // Create a list from an input
                var strList = input.Split(",").ToList();

                // Convert all list elements into integers
                var numList = strList.Select(str => Convert.ToInt32(str));


                // Make sure the user types 5 numbers
                if (numList.Count() == 5)
                {
                    // Add an input to total
                    total.AddRange(numList);

                    // Check if items are unique
                    var isUniq = total.Distinct().Count() == total.Count();

                    if (isUniq == true)
                    {
                        Console.WriteLine("All entered numbers are unique: ");
                        var sortedList = numList.OrderBy(x => x).ToList();
                        foreach (var item in sortedList)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {   // Remove previously added input
                        total.RemoveRange(total.Count - 5, 5);
                        Console.WriteLine("Your numbers are not unique. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("(!) Please type exactly 5 numbers.");
                    continue;
                }

            }
        }
    }
}
