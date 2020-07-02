using System;
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

        public static List<GameResult> ReadSoccerResults(string fileName)
        {
            var soccerResults = new List<GameResult>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var gameResult = new GameResult();
                    string[] values = line.Split(',');

                    DateTime gameDate;
                    if (DateTime.TryParse(values[0], out gameDate))
                    {
                        gameResult.GameDate = gameDate;
                    }

                    HomeOrAway homeOrAway;
                    if (Enum.TryParse(values[2], out homeOrAway))
                    {
                        gameResult.HomeOrAway = homeOrAway;
                    }

                    int goals;
                    if (int.TryParse(values[3], out goals))
                    {
                        gameResult.Goals = goals;
                    }

                    int goalAttempts;
                    if (int.TryParse(values[4], out goalAttempts))
                    {
                        gameResult.GoalAttempts = goalAttempts;
                    }

                    int shotsOnGoal;
                    if (int.TryParse(values[5], out shotsOnGoal))
                    {
                        gameResult.ShotsOnGoal = shotsOnGoal;
                    }

                    int shotsOffGoal;
                    if (int.TryParse(values[6], out shotsOffGoal))
                    {
                        gameResult.ShotsOffGoal = shotsOffGoal;
                    }

                    double posessionPercent;
                    if (double.TryParse(values[7], out posessionPercent))
                    {
                        gameResult.PossesionPercent = posessionPercent;
                    }

                    gameResult.TeamName = values[1];
                    soccerResults.Add(gameResult);
                }
            }
            return soccerResults;
        }
    }
}
