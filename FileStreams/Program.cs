using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            // open or create a file and write 7 bytes to it
            byte[] outBuffer = new byte[] { (byte)'a', 1, 2, 3, 4, 5, 6, 7 };
            using (FileStream stream = new FileStream("test.bin", FileMode.OpenOrCreate))
            {
                Console.WriteLine("Writing buffer to file...");
                stream.Write(outBuffer, 0, outBuffer.Length);
            }

            // open a file and read all bytes, then display them on the screen
            byte[] inBuffer = new byte[100];
            using (FileStream stream = new FileStream("test.bin", FileMode.Open))
            {
                int numberOfBytesRead = stream.Read(inBuffer, 0, outBuffer.Length);

                Console.WriteLine($"Total Bytes Read: {numberOfBytesRead}");
                Console.WriteLine($"Content: {string.Join(",", inBuffer.Take(numberOfBytesRead))}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
