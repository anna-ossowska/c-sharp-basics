using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---File class provides static methods---
            var path = @"c:\temp\myfile.jpg";

            // true means - if the file of the same name exists, overwrite it
            File.Copy(path, @"d:\temp\myfile.jpg", true);

            File.Delete(path);

            var msg = (File.Exists(path)) ? "Exists" : "Does not exist";
            Console.WriteLine(msg);

            var content = File.ReadAllText(path);


            // ---FileInfo class provides instance methods---
            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("...");

            fileInfo.Delete();

            var msg2 = fileInfo.Exists ? "Exists" : "Does not exist";
        }
    }
}
