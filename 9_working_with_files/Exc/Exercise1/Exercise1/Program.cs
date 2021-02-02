using System;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Write a program that reads a text file and displays the number of words.

            var path = @"C:\Users\tomas\Desktop\my_files\folder1\notes.txt";

            var words = CountWordsInFile(path);

            Console.WriteLine($"Your file contains {words} words");
        }

       public static string CountWordsInFile(string path)
        {
            var text = File.ReadAllText(path);
            return text.Split(" ").Length.ToString();
        }
    }
}
