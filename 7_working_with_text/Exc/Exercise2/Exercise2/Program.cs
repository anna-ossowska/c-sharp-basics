using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately;
            //    otherwise, check to see if there are duplicates. If so, display "Duplicate detected" on the console.

            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            var numList = new List<int>();

            while (true)
            {
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    var inputSplit = input.Split('-');

                    foreach (var item in inputSplit)
                    {
                        numList.Add(Convert.ToInt32(item));
                    }

                    var isUnique = numList.Distinct().Count() == numList.Count();

                    if (isUnique)
                    {
                        Console.WriteLine("No duplicates.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Duplicate detected.");
                        break;
                    }
                }
            }
        }
    }
}
