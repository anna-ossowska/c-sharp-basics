using System;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            Console.WriteLine(dateTime);

            var now = DateTime.Now;
            Console.WriteLine(now);

            var today = DateTime.Today;
            Console.WriteLine(today);

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            // DateTime objects are immutable
            // To modify an existing DateTime object use the Add methods:
            var tomorrow = now.AddDays(1);
            Console.WriteLine(tomorrow);

            var yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday);

            // Converting to String
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            // Using both DateString and TimeString
            Console.WriteLine(now.ToString());

            // Format specifiers:
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        }
    }
}
