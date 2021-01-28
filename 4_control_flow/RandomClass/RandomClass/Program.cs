using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random1 = new Random();
            for (var i = 0; i < 10; i++)
            {
                // Generating random numbers from the range
                Console.WriteLine(random1.Next(1, 10));
            }

            var random2 = new Random();
            for (var i = 0; i < 10; i++)
            {
                // Generating random letters - 97 and 122 represent 'a' and 'z' in the ASCII table
                Console.Write((char)random2.Next(97, 122));
            }

            var random3 = new Random();
            for (var i = 0; i < 10; i++)
            {
                // Generating random letters - 26 represents the total number of letters in an English alphabet
                // 'a' + 0 = 97, it's an implicit casting to an integer
                Console.WriteLine((char)('a' + random3.Next(0, 26)));
            }
        }
    }
}