using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 - Write a program and ask the user to enter a few words separated by a space.
            //    Use the words to create a variable name with PascalCase.
            //    For example, if the user types: "number of students", display "NumberOfStudents".
            //    Make sure that the program is not dependent on the input.
            //    So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.WriteLine("Enter a few words separated by a space.");

            var input = Console.ReadLine().ToLower();

            var inputSplit = input.Split(" ").ToList();

            var output = new List<string>();

            var newString = "";        

            for (int i = 0; i < inputSplit.Count(); i++)
            {
                newString = inputSplit[i][0].ToString().ToUpper() + inputSplit[i].Substring(1);
                output.Add(newString);
            }

            var concat = String.Join("", output);
            Console.WriteLine(concat);
        }
    }
}
