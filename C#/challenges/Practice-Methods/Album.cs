namespace Treehouse.MediaLibrary
{
    class Album : MediaType
    {
        // public readonly string Title;
        public readonly string Artist;

        public Album(string title, string artist) : base(title)
        {
            Artist = artist;
        }
        public string GetDisplayText()
        {
            string message = $"Album: {Title} by {Artist}";
            if (!string.IsNullOrEmpty(Loanee)) return $"{message} (Currently loaned out to {Loanee})";
            else if (OnLoan) return $"{message} (Currently Loaned out)";
            else return message;
        }
    }
}