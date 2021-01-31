using System;
using System.Linq;  

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            //    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //    otherwise, display the 3 smallest numbers in the list.


            while (true)
            {
                Console.WriteLine("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                var input = Console.ReadLine();

                // Remove white spaces:
                var clearInput = input.Replace(" ", "");

                // Convert input to List
                var inputList = clearInput.Split(",").ToList();

                if (inputList.Count() != 5)
                {
                    Console.WriteLine("(!) Invalid List.");
                    Console.WriteLine("Please try again.");
                }

                else
                {
                    // Converting to integer
                    var intList = inputList.Select(x => Convert.ToInt32(x));

                    // Sorting
                    var sortedList = intList.OrderBy(x => x).ToList();

                    Console.WriteLine($"Three the smallest numbers are: {sortedList[0]}, {sortedList[1]} and {sortedList[2]}.");
                }
            }
        }
    }
}
