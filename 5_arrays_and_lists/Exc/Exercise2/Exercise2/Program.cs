using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.
            // Display the reversed name on the console.

        // Solution 1 (using Array)
            Console.WriteLine("Enter your name: ");
            var inputName = Console.ReadLine();
            var charArr = new char[inputName.Length];

            for (int i = inputName.Length; i > 0; i--)
            {
                charArr[i - 1] = inputName[inputName.Length - i];
                
            }

            var reversed = new string(charArr);

            Console.WriteLine(char.ToUpper(reversed[0]) + reversed.Substring(1).ToLower());


        // Solution 2 (using List)
            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();
            var charList = new List<Char>();

            // Add chars into the List
            for (int i = 0; i < input.Length; i++)
            {
                charList.Add(input[i]);
            }

            // Reverse elements inside the List
            charList.Reverse();

            // Convert to String
            var nameReversed = String.Join("", charList);
            Console.WriteLine("Reversed name: {0}{1}", char.ToUpper(nameReversed[0]), nameReversed.Substring(1).ToLower());
        }
    }
}


