using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rewrite your code using the Procedural Programming paradigm

            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately;
            //    otherwise, check to see if there are duplicates. If so, display "Duplicates detected" on the console.

            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();


            while (true)
            {
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    var inputSplit = input.Split('-');
                    var msg = DetectDuplicates(inputSplit);

                    if (msg)
                    {
                        Console.WriteLine("No duplicates.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Duplicates detected.");
                        break;
                    }
                }
            }
        }

        public static bool DetectDuplicates(string[] num)
        {
            var numList = new List<int>();
            foreach (var item in num)
            {
                numList.Add(Convert.ToInt32(item));
            }

            return numList.Distinct().Count() == numList.Count();
        }
    }
}