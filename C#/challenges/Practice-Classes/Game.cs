using System;

namespace Treehouse.MediaLibrary
{
    class Game
    {
        public readonly string Title;
        public readonly string Platform;
        public readonly string Rating;

        public Game(string title, string platform, string rating)
        {
            Title = title;
            Platform = platform;
            Rating = rating;
        }
        public void Description()
        {
            Console.WriteLine($"{Title} is on {Platform}, ESRB Rating {Rating}");
        }
    }
}