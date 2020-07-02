using System;
using System.IO;
using System.Xml.Xsl;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDir = Directory.GetCurrentDirectory();
            var directory = new DirectoryInfo(currentDir);
            var filename = Path.Combine(directory.FullName, "data.txt");
            var file = new FileInfo(filename);
            if (file.Exists)
            { 
                using (var reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }
                Console.ReadLine();
            }
        }
    }
}
