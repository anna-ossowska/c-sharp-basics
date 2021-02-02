
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rewrite your code using the Procedural Programming paradigm

            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00).
            //    A valid time should be between 00:00 and 23:59.
            //    If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            //    If the user doesn't provide any values, consider it as invalid time.

            Console.WriteLine("Enter a time (i.e.: 19:00");
            var input = Console.ReadLine();

            Console.WriteLine(VlidateTime(input));
        }

        public static string VlidateTime(string time)
        {
            // Exlude ':'
            var numbers = string.Concat(time.Substring(0, 2), time.Substring(3));

            // Define ranges
            IEnumerable<int> range1 = Enumerable.Range(0, 2);
            IEnumerable<int> range2 = Enumerable.Range(2, 3);
            IEnumerable<int> range3 = Enumerable.Range(0, 10);
            IEnumerable<int> range4 = Enumerable.Range(0, 6);
            IEnumerable<int> range5 = Enumerable.Range(0, 4);

            // Create an empty list for integers
            var numList = new List<int>();

            // Convert numeric characters to Int32:
            // In ASCII digits 0-9 start from 48-57
            // To change the numeric character to an integer subtract 48
            foreach (var item in numbers)
            {
                numList.Add(Convert.ToInt32(item) - 48);
            }

            // Accepts the format: 19:59
            if (range1.Contains(numList[0]) && range3.Contains(numList[1]) && time[2] == ':' && range4.Contains(numList[2]) && range3.Contains(numList[3]))
            {
                return "Ok";
            }
            // Accepts the format: 23:59
            else if (range2.Contains(numList[0]) && range5.Contains(numList[1]) && time[2] == ':' && range4.Contains(numList[2]) && range3.Contains(numList[3]))
            {
                return "OK";
            }
            else
            {
                return "Invalid time";
            }
        }
    }
}
