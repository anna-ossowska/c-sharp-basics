using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            // Chaining methods
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('x', 10));

            Console.WriteLine(builder);

            // Get the first character
            Console.WriteLine("First character: " + builder[0]);
        }
    }
}
