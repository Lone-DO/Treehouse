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
            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            var fileContents = ReadFile(fileName);
            var fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.Write(fileContents);

            foreach (var line in fileLines)
            {
                Console.WriteLine(line);
            }
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
