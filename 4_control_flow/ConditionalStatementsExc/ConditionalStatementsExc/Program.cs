using System;

namespace ConditionalStatementsExc
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Write a program and ask the user to enter a number.
            // The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.
            // Otherwise, display "Invalid".

            Console.WriteLine("Enter a number: ");
            var inputInt = Convert.ToInt32(Console.ReadLine());

            if (inputInt > 0 && inputInt < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // 2 - Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Type the first number:");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            var input2 = Convert.ToInt32(Console.ReadLine());

            if (input1 > input2)
            {
                Console.WriteLine($"The max value is: {input1}.");
            }
            else
            {
                Console.WriteLine($"The max value is: {input2}.");
            }

            // 3 - Write a program and ask the user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait.

            Console.WriteLine("Enter the width of an image: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter the height of an image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Your image is a landscape.");
            }
            else
            {
                Console.WriteLine("Your image is a portrait");
            }


            //4 - Your job is to write a program for a speed camera.
            //    Asks the user to enter the speed limit.
            //    Once set, the program asks for the speed of a car.
            //    If the user enters a value less than the speed limit, program should display Ok on the console.
            //    If the value is above the speed limit, the program should calculate the number of demerit points.
            //    For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //    If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("Enter a speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a speed of a car: ");
            var speedCar = Convert.ToInt32(Console.ReadLine());
            var demeritPointsTotal = (speedCar - speedLimit) / 5;
            var point = 1;

            if (speedCar < speedLimit)
            {
                Console.WriteLine("OK.");
            }
            else
            {
                if (demeritPointsTotal <= 12)
                {
                    // Print the given demerit points, one by one
                    while (point <= demeritPointsTotal)
                    {
                        Console.WriteLine($"Demerit points: {point++}");
                    }              
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
