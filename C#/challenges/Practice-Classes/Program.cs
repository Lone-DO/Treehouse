using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            Game[] games = {
                new Game("Uncharted 4", "PS4", "M"),
                new Game("Animal Crossing: New Leaf", "Nintendo Switch", "A"),
                new Game("Halo: Reach", "Xbox", "Teen")
            };

            foreach (var game in games)
            {
                game.Description();
            }
        }
    }
}