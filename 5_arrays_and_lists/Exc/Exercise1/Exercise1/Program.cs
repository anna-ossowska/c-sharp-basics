using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            // If no one likes your post, it doesn't display anything.
            // If only one person likes your post, it displays: [Friend's Name] likes your post.
            // If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
            // If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.

            // Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).
            // Depending on the number of names provided, display a message based on the above pattern.


            Console.WriteLine("Enter a name: ");
            Console.WriteLine("Or press enter to exit");

            var input = "";
            input = Console.ReadLine();

            var likes = 0;
            var friends = new List<string>();

            while (!string.IsNullOrEmpty(input))
            {
                if (likes == 1)
                {
                    friends.Add(input);
                    Console.WriteLine($"{friends[0]} likes your post");
                    input = Console.ReadLine();
                }

                else if (likes == 2)
                {
                    friends.Add(input);
                    Console.WriteLine($"{friends[0]} and {friends[1]} like your post");
                    input = Console.ReadLine();
                }
                else if (likes >= 3)
                {
                    friends.Add(input);
                    Console.WriteLine($"{friends[0]}, {friends[1]} and {friends.Count - 2} others like your post");
                    input = Console.ReadLine();
                }
                likes++;
            }
        }
    }
}
