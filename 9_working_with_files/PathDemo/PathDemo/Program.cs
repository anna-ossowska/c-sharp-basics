using System;
using System.IO;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\tomas\Desktop\my_files\folder1\Doc10.docx";

            Console.WriteLine("Extension: " + Path.GetExtension(path));

            Console.WriteLine("File Name: " + Path.GetFileName(path));

            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
