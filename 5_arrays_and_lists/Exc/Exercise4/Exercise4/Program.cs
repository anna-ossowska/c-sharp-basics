using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //    The list of numbers may include duplicates.
            //    Display the unique numbers that the user has entered.

            var input = "";
            var total = new List<string>();

            while (input != "Quit")
            {
                Console.WriteLine("Enter one or more numbers seperated by comma: ");
                Console.WriteLine("Or type 'Quit' to exit.");
                input = Console.ReadLine();

                // Create a list out of the user's input
                var strList = input.Split(",").ToList();

                foreach (var item in strList)
                {
                    if (item == "Quit")
                    {
                        Console.WriteLine("Closing the program...");
                    }
                    else if (!total.Contains(item))
                    {
                        Console.WriteLine($"The uniqe value: {item}");
                    }
                    else
                    {
                        Console.WriteLine("Some numbers you have entered are duplicates.");
                    }
                }

                // Add etered numbers to total
                total.AddRange(strList);
            }
        }
    }
}
