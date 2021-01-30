using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            // Add
            numbers.Add(3);
            
            // AddRange 
            numbers.AddRange(new int[4] { 5, 6, 7, 3 });
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // IndexOf
            var index = numbers.IndexOf(3);
            Console.WriteLine($"Index of 3: {index}.");

            // LastIndexOf
            var lastIndex = numbers.LastIndexOf(3);
            Console.WriteLine($"Index of 3: {lastIndex}.");

            // Count
            Console.WriteLine($"The list is consisting of {numbers.Count} elements.");

            // Remove (3 is repeated inside the list, this method removes only one instance of 3)
            numbers.Remove(3);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Remove all instances of 3
            // We need to use the for loop to avoid throwing an Error
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 3)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            // Pring the results
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Clear
            numbers.Clear();
            Console.WriteLine($"Count: {numbers.Count}.");
        }
    }
}
