using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rewrite your code using the Procedural Programming paradigm

            //4 - Write a program and ask the user to enter a few words separated by a space.
            //    Use the words to create a variable name with PascalCase.
            //    For example, if the user types: "number of students", display "NumberOfStudents".
            //    Make sure that the program is not dependent on the input.
            //    So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.WriteLine("Enter a few words separated by a space.");
            var input = Console.ReadLine();

            Console.WriteLine(CreatePascalCase(input));
        }

        public static string CreatePascalCase(string words)
        {
            var wordsSplit = words.ToLower().Split(" ").ToList();

            var output = new List<string>();

            var formattedWords = "";

            for (int i = 0; i < wordsSplit.Count(); i++)
            {
                formattedWords = wordsSplit[i][0].ToString().ToUpper() + wordsSplit[i].Substring(1);
                output.Add(formattedWords);
            }

            var concat = String.Join("", output);
            return concat;
        }
    }
}