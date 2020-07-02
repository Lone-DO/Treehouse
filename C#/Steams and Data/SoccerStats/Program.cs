using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Xsl;
using Newtonsoft.Json;
using System.Net;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //string currentDir = Directory.GetCurrentDirectory();
            //var directory = new DirectoryInfo(currentDir);
            //var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            //var fileContents = ReadSoccerResults(fileName);
            //fileName = Path.Combine(directory.FullName, "players.json");
            //var players = DeserializePLayers(fileName);
            //var topTenPlayers = GetTopTenPlayers(players);
            //foreach (var player in topTenPlayers)
            //{
            //    Console.WriteLine($"Name: {player.FirstName}, Points Per Game: {player.PointsPerGame}");
            //}

            //fileName = Path.Combine(directory.FullName, "topTenPlayers.json");
            //SerializePlayesToFile(topTenPlayers, fileName);

            Console.WriteLine(GetGoogleHomePage());
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<Player> DeserializePLayers(string fileName)
        {
            var players = new List<Player>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                players = serializer.Deserialize<List<Player>>(jsonReader);
            }
            return players;
        }

        public static void SerializePlayesToFile(List<Player> players, string fileName)
        {
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, players);
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

                    gameResult.TeamName = values[1];
                    
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

                    soccerResults.Add(gameResult);
                }
            }
            return soccerResults;
        }

        public static List<Player> GetTopTenPlayers(List<Player> players)
        {
            var topTenPlayers = new List<Player>();
            players.Sort(new PlayerComparer());
            int counter = 0;
            foreach (var player in players)
            {
                topTenPlayers.Add(player);
                counter++;
                if (counter == 10) break;
            }
            return topTenPlayers;
        }

        public static string GetGoogleHomePage()
        {
            var webClient = new WebClient();
            byte[] googleHome = webClient.DownloadData("https://www.google.com");

            using (var stream = new MemoryStream(googleHome))
            using (var reader = new StreamReader(stream))
            {
               return reader.ReadToEnd();
            }
        }
    }
}
