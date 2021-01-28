using System;

namespace RandomClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            // Taking a random set of characters from an array and storing them in a string
            // 1st solution:
            var password = new string(buffer);
            Console.WriteLine(password);

            // 2nd solution:
            // var password = String.Join("", buffer);
        }
    }
}
