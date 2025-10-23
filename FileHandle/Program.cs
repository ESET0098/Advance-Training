using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(Path.GetFullPath("filename.txt"));  // Check if file exists)
            Console.WriteLine(readText);
        }
    }
}
