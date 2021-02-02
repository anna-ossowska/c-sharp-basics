using System;
using System.IO;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 - Write a program that reads a text file and displays the longest word in the file.

            var path = @"C:\Users\tomas\Desktop\my_files\folder1\notes.txt";

            var longestWord = DisplayLongest(path);
            Console.WriteLine($"The longest word in your file is: {longestWord}");
        }

        public static string DisplayLongest(string path)
        {
            var text = File.ReadAllText(path);

            var words = text.Split(" ");

            // Assume the first word is the longest one
            var longest = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (longest.Length < words[i].Length)
                {
                    longest = words[i];
                }
            }
            return longest;
        }
    }
}
