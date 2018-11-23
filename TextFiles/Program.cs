using System;
using System.IO;

namespace TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // old school, not nice but it's actually what happens with using
            Stream stream = null;
            TextWriter writer = null;
            try
            {
                stream = new FileStream("test.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(stream);

                writer.WriteLine("Finally I wrote something in my file :)");
            }
            finally
            {
                // in case there are any exceptions we must guarantee 
                // that the writer and the streams are closed and disposed


                writer?.Close();
                writer?.Dispose();

                stream?.Close();
                stream?.Dispose();
            }


            // open file for writing and append one line of text
            using (Stream str = new FileStream("test.txt", FileMode.Append, FileAccess.Write))
            using (TextWriter wr = new StreamWriter(str))
            {
                wr.WriteLine("Written in a better way :)");
            }

            // open file for appending and write a single line of text
            using (var wr = File.AppendText("test.txt"))
            {
                wr.WriteLine("It's much simple this way!");
            }
           
            // open file for reading and display its content in the console
            using (Stream str = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
            using (TextReader rdr = new StreamReader(str))
            {
                string fileInput = rdr.ReadToEnd();

                Console.WriteLine(fileInput);
            }

            Console.WriteLine("------------------------------------------");

            // open file and read all content, then write it to the console (same as above, but much simpler)
            Console.WriteLine(File.ReadAllText("test.txt"));



            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
