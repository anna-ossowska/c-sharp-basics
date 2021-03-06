﻿using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)

        {
            // Rewrite your code using the Procedural Programming paradigm

            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    Work out if the numbers are consecutive.
            //    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();

            var inputSplit = input.Split('-');
            Console.WriteLine(GetNumbers(inputSplit));
        }

        public static string GetNumbers(string[] num)
        {
            var numList = new List<int>();

            foreach (var item in num)
            {
                numList.Add(Convert.ToInt32(item));
            }

            if (numList[numList.Count - 1] - (numList.Count - 1) == numList[0])
            {
                return "Consecutive";
            }
            else if (numList[numList.Count - 1] + (numList.Count - 1) == numList[0])
            {
                return "Consecutive";
            }
            else
            {
                return "Not Consecutive";
            }
        }
    }
}
