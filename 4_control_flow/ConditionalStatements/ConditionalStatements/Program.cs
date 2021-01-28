using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 13;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.99f;
            //}

            // Ternary operator
            float price = (isGoldCustomer) ? 19.95f : 29.99f;
            Console.WriteLine(price);

            // Switch statement
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a seasonal sale!");
                    break;

                default:
                    Console.WriteLine("I don't understand your input.");
                    break;
            }
        }
    }
}
