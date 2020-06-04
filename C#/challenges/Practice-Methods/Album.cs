namespace Treehouse.MediaLibrary
{
    class Album : MediaType
    {
        // public readonly string Title;
        public string Artist { get; set; }

        public Album(string title, string artist) : base(title)
        {
            Artist = artist;
        }
        public string DisplayText => $"Album: {Title} by {Artist} {OnLoanText}";
    }
}