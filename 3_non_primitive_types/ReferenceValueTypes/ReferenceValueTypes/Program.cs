using System;

namespace ReferenceValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types
            // Integer is a Structure
            // a and b are allocated on the stack
            // These two variables are completely independent and making any change to one, does not impact the other
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("Value a: {0} Value b: {1}", a, b));

            // Reference types
            // Array is a Class
            // Object with an address is allocated on the heap
            // Both arr1 and arr2 are located on the stack and they point (reference) object on the heap
            // That's why making changes to one variable affects the other
            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;
            arr2[0] = 0;
            Console.WriteLine(string.Format("arr1[0]: {0} arr2[0]: {1}", arr1[0], arr2[0]));
        }
    }
}
