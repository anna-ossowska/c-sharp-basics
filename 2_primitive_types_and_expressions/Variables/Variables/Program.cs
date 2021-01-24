using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte number = 2;
            // int count = 10;
            // float totalPrice = 12.2f;
            // char letter = 'A';
            // string firstName = "Anna";
            // bool isWorking = true;

            var number = 2;
            var count = 10;
            var totalPrice = 12.2f;
            var letter = 'B';
            var firstName = "Anna";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(letter);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            Console.WriteLine(Pi);
        }
    }
}