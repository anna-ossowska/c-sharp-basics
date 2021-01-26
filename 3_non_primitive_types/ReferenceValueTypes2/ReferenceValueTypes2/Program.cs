using System;

namespace ReferenceValueTypes2
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {   
            // This block belongs to the scope of the Main method
            // Thus, number is not affected by the Increment method
            int number = 1;
            Increment(number);
            Console.WriteLine(number);

            // Both person object inside the Main method and person object being a parameter to MakeOld method,
            // are pointing to the same object on the heap
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
