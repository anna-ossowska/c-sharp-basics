using System;
using System.Collections.Generic;

namespace ControlFlowExc
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            // Display the count on the console.

            var divisibleNums = new List<int>();
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleNums.Add(i);
                }
            }

            Console.WriteLine($"There are {divisibleNums.Count} numbers divisible by 3 with no remainder.");
        }
    }
}