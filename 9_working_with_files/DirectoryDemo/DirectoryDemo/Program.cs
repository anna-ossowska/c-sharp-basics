using System;
using System.IO;

namespace DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---Directory class provides static methods---

            Directory.CreateDirectory(@"C:\Users\tomas\Desktop\my_files\folder1");

            // "*" means all files
            // the return type is string[]
            var files = Directory.GetFiles(@"C:\Users\tomas\Desktop\my_files", "*.docx", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\tomas\Documents\anna\repos", "*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Console.WriteLine(Directory.Exists(@"C:\Users\tomas\Documents\anna\repos"));


            // ---DirectoryInfo class provides instance methods---

            var directoryInfo = new DirectoryInfo(@"C:\Users\tomas\Documents\anna\repos");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
