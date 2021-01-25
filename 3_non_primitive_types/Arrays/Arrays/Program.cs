using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] number = new int[3];
            var number = new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]); // 1
            Console.WriteLine(number[1]); // value not declared manually, so C# assigns the default value for an Integer which is 0
            Console.WriteLine(number[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
