using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            //var a = 10;
            //var b = 3;
            //Console.WriteLine((float)a / (float)b);

            // Comparison Operators
            //var a = 1;
            //var b = 2;
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);

            // Logical Operators
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(!(a <= 3 && b < 3 || b == c));

            // Bitwise Operators use single & and | (they are used in low-level programming)
        }
    }
}
