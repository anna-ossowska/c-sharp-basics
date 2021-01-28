using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";

            // Iterating through the sentence's characters using the for loop
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // Iterating through the sentence's characters using the foreach
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // Iterating through an array
            var numbers = new int[4] { 1, 2, 3, 4 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
