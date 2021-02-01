using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trim
            var fullName = "Anna Ossowska ";
            Console.WriteLine($"Trim: '{fullName.Trim()}'");

            // Chaining methods:
            Console.WriteLine($"ToUpper: {fullName.Trim().ToLower()}");

            // Splitting the name into first and last name
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");

            // The same effect with the split method
            var names = fullName.Split(' ');
            Console.WriteLine($"firstName: {names[0]} \nlastName: {names[1]}");

            // Replace
            Console.WriteLine(fullName.Replace("Anna", "Ania"));

            // Validation 1
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }

            // Validation 2, cleaner version
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            // Converting
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 12.34f;
            var priceCurrency = price.ToString("C0");
            Console.WriteLine(priceCurrency);
        }
    }
}
