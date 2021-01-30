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

            Console.WriteLine("Enter your name: ");
            var inputName = Console.ReadLine();
            var charArr = new List<Char>();

            // Add chars into the Array
            for (int i = 0; i < inputName.Length; i++)
            {
                charArr.Add(inputName[i]);
            }

            // Reverse elements inside the Array
            charArr.Reverse();

            // Convert to String
            var nameReversed = String.Join("", charArr);
            Console.WriteLine("Reversed name: {0}{1}", char.ToUpper(nameReversed[0]), nameReversed.Substring(1).ToLower());
        }
    }
}
