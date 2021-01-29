using System;
using System.Linq;

namespace ControlFlowExc5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Write a program and ask the user to enter a series of numbers separated by comma.
            //    Find the maximum of the numbers and display it on the console.
            //    For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter a series of numbers seperated by comma");
            string input = Console.ReadLine();

            var arrNum = input.Split(",");
            Console.WriteLine($"The maximum value is {arrNum.Max(n => Convert.ToInt32(n))}.");
        }
    }
}


