using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rewrite your code using the Procedural Programming paradigm

            //5 - Write a program and ask the user to enter an English word.
            // Count the number of vowels(a, e, o, u, i) in the word.
            // So, if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("Enter an English word: ");
            var input = Console.ReadLine();

            Console.WriteLine($"Your word contains {CountVowels(input)} vowels.");
        }

        public static string CountVowels(string word)
        {
            var input = word.ToLower();
            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'i' || input[i] == 'e' || input[i] == 'a' || input[i] == 'o' || input[i] == 'u')
                {
                    sum++;
                }
            }
            return sum.ToString();
        }
    }
}