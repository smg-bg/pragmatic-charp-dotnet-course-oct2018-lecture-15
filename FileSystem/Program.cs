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
            Console.WriteLine(Path.Combine("C:\\windows", "system32"));
           

            Console.WriteLine("\n-------------------------------------------------\n");

            // File static class
            if (File.Exists(@"C:\my_special_file.txt"))
            {
                Console.WriteLine("Crazy file exists :)");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.WriteLine("\n-------------------------------------------------\n");

            // Directory static class
            Console.WriteLine(string.Join("\n", Directory.EnumerateFileSystemEntries("C:\\")));

            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(Environment.CurrentDirectory);

            Console.WriteLine(string.Join(",", Directory.GetLogicalDrives()));

            Console.WriteLine("\n-------------------------------------------------\n");

            // FileSystemInfo, DirectoryInfo and FileSystemInfo classes
            var root = new DirectoryInfo(@"C:\Users\smg\Desktop\CSharp Course");
            TraverseFolder(root);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void TraverseFolder(DirectoryInfo root)
        {
            var files = root.GetFiles();

            foreach (var f in files)
                Console.WriteLine($"[F]: {f.FullName}");

            var dirs = root.GetDirectories();

            foreach (var d in dirs)
            {
                Console.WriteLine($"[D]: {d.FullName}");
                TraverseFolder(d);
            }
        }
    }
}
