using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path static class
            Console.WriteLine(Path.GetTempFileName());
            Console.WriteLine(Path.GetExtension("./FileSystem.exe"));
            Console.WriteLine(Path.GetFullPath("./FileSystem.exe"));
            // TBA

            Console.WriteLine("\n-------------------------------------------------");

            // File static class
            // TBA

            // Directory static class
            // TBA

            // FileSystemInfo, DirectoryInfo and FileInfo classes
            // TBA
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
