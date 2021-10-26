using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples";
            string userdirectory = "wishlist";

            string newDirectoryPath = $@"{rootdirectory}\{userdirectory}";
            Console.WriteLine(newDirectoryPath);
            Directory.CreateDirectory(newDirectoryPath);
        }
    }
}
