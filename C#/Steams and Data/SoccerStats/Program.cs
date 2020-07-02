﻿using System;
using System.Collections.Generic;
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
            var fileContents = ReadSoccerResults(fileName);
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<string[]> ReadSoccerResults(string fileName)
        {
            var soccerResults = new List<string[]>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values  = line.Split(',');
                    soccerResults.Add(values);
                }
            }
            return soccerResults;
        }
    }
}
