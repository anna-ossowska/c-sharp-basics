using System;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Creating a TimeSpan object
            var timeSpan = new TimeSpan(1, 2, 3); // O1:02:03
            Console.WriteLine(timeSpan);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            Console.WriteLine(timeSpan1);

            // More readable way to create a TimeSpan object
            var timeSpan2 = TimeSpan.FromHours(1); // 01:00:00
            Console.WriteLine(timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // 2 minutes
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes); // converts timeSpan object to minutes: 62,05

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            // Subtract
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("To String: " + timeSpan.ToString());

            // Parse from String
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
