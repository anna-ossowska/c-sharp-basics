using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var age = calculator.Add(12, 30);
            Console.WriteLine(age);
        }
    }
}
