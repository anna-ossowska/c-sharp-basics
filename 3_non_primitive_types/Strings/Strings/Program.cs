using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Anna";
            var lastName = "Ossowska";

            // String concatenation:
            var fullName = "Anna" + " " + "Ossowska";
            Console.WriteLine(fullName);

            // String Format method (composite formatting):
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            // Interpolation:
            Console.WriteLine($"My name is {firstName} {lastName}.");

            // Join method:
            var names = new string[3] { "John", "Jake", "Mary" };
            var joinedNames = string.Join(',', names);
            Console.WriteLine(joinedNames);

            // Verbatim Strings:
            var path = @"Hi John,
Look into the following paths:
c:\folder1\file1
c:\folder2\file2";
            Console.WriteLine(path);
        }
    }
}
